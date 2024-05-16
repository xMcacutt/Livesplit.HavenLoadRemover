﻿using LiveSplit.TimeFormatters;
using System.IO;

namespace LiveSplit.Model.RunSavers
{
    public class SplitterZRunSaver : IRunSaver
    {
        protected string Escape(string text)
        {
            return text.Replace(@",", @"‡");
        }

        public void Save(IRun run, Stream stream)
        {
            var regularTimeFormatter = new RegularTimeFormatter(TimeAccuracy.Hundredths);
            var shortTimeFormatter = new ShortTimeFormatter();

            var writer = new StreamWriter(stream);

            if (!string.IsNullOrEmpty(run.GameName))
            {
                writer.Write(Escape(run.GameName));

                if (!string.IsNullOrEmpty(run.CategoryName))
                    writer.Write(" - ");
            }

            writer.Write(Escape(run.CategoryName));
            writer.Write(',');
            writer.WriteLine(Escape(run.AttemptCount.ToString()));

            foreach (var segment in run)
            {
                writer.Write(Escape(segment.Name));
                writer.Write(',');
                writer.Write(Escape(regularTimeFormatter.Format(segment.PersonalBestSplitTime.RealTime)));
                writer.Write(',');
                writer.WriteLine(Escape(shortTimeFormatter.Format(segment.BestSegmentTime.RealTime)));
            }

            writer.Flush();
        }
    }
}
