using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Util;

namespace Livesplit.HavenLoadRemover
{
    internal class ImageComparison
    {
        static bool b = false;
        public static double CompareImages(string loadImagePath, Mat feedImage)
        {
            Mat loadImage = CvInvoke.Imread(loadImagePath);

            int[] channels = { 0 }; // Use only 1 channel
            int[] histSize = { 256 }; // Number of bins
            float[] ranges = { 0, 256 }; // Range of pixel values

            Mat grayFeedImage = new Mat();
            CvInvoke.CvtColor(feedImage, grayFeedImage, ColorConversion.Bgr2Gray);
            UMat resizedGrayFeedImage = new UMat();
            CvInvoke.Resize(feedImage, resizedGrayFeedImage, loadImage.Size);
            VectorOfUMat vouFeed = new VectorOfUMat();
            vouFeed.Push(resizedGrayFeedImage);
            Mat feedHist = new Mat();
            CvInvoke.CalcHist(vouFeed, channels, null, feedHist, histSize, ranges, false);

            UMat grayLoadImage = new UMat();
            CvInvoke.CvtColor(loadImage, grayLoadImage, ColorConversion.Bgr2Gray);
            VectorOfUMat vouLoad = new VectorOfUMat();
            vouLoad.Push(grayLoadImage);
            Mat loadHist = new Mat();
            CvInvoke.CalcHist(vouLoad, channels, null, loadHist, histSize, ranges, false);

            double similarity = CvInvoke.CompareHist(loadHist, feedHist, HistogramCompMethod.Intersect) / 10000;

            return similarity;
        }
    }
}
