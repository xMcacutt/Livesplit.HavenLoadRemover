# Haven: Call of the King Load Remover
This is a livesplit component to be used when speedrunning Haven: Call of the King.
It allows the runner to select a window to be captured and then pauses the game when the load screen is detected.
Image comparison is done using Emgu.CV and the intersection of histograms method. 
Using a visual image comparison based component rather than a script hooking into the process allows original hardware runners to use the same load removal as emulator runners.
An autosplitter should also be available in the near future (as of 18/05/2024).

## Setup
- Download the zip from the releases page and copy ALL of its contents into your livesplit/components folder.
- Open livesplit.
- Right click -> Edit Layout
- Click the + to add a new component.
- Go to: Control -> HCOTK Load Remover
- Select the window which displays Haven. This can be obs or an emulator.
- Crop the window using the controls so Haven fits into the 4:3 cropping area.
- Note the similarity value in the top right and then go to a load screen. The similarity value should increase.
- Put the sensitivity to as close to the stable value of the similarity on the load screen as possible.
- Run the game.