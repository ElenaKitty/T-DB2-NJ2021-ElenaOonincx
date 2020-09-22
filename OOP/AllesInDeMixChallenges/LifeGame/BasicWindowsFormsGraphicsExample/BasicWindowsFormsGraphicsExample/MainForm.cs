using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWindowsFormsGraphicsExample
{
    /// <summary>
    /// Just some sample code to show how custom (GDI+) painting works in a winform application.
    /// 
    /// (its not an example of how classes using custom drawing should look like :-). 
    /// Learn the mechanics of custom painting and embed it in your own code in a valid manner.
    /// </summary>
    public partial class MainForm : Form
    {
        private bool isDrawingFace;
        private Point movingRectanglePosition;
        private Timer gameTimer;

        public MainForm()
        {
            InitializeComponent();
  
            isDrawingFace = false;
            movingRectanglePosition = new Point(200, 50);

            // Want to force regular UI updates? Use a timer. For example:
            gameTimer = new Timer();
            SetupTimer(gameTimer);
            // Hint: Please read / use / learn about timers only after your read about custom drawing in this example program.
        }

        private void gamePictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Custom drawing, must be done in the paint (event) method of UI widget that you want use to
            // show your custom drawing. 
            // 
            // In this example program the 'gamePictureBox' is used to show the custom drawing (i.e you must draw on an existing UI widget).
            // All code for drawing the custom graphics must be inside (or be called from) the paint event 
            // method of the 'gamePictureBox'. Which in this case is the gamePictureBox_Paint(...) method.
            //
            // You must not call the paint event method directly. Call "gamePictureBox.Refresh();" instead.
            // Calling gamePictureBox.Refresh() will force your graphics system to repaint the UI of the 
            // gamePictureBox object. It does so by executing the paint event method of the object
            // (in this case: gamePictureBox_Paint)
            // 
            // Some nice to knows (you can skip this) about event methods.
            //     You may NOT call event methods in your code directly/manually, which is 
            //     perfectly normal for event methods.           
            //     
            //     Event methods aren't new subjects to you. You used them already when making UI buttons 
            //     do your work. See for example 'drawButton_Click' in this file. Did you ever called this
            //     kind of 'Click' event methods manually from your code?
            //     I hope not :) These kind of methods are called 'automagically' by the runtime environment 
            //     of your C# UI application. 
            //     In case of the Click event method: it is called when the button, to which it belongs, 
            //     is clicked by the user.
            //
            //     The Paint event method (this method) works in the same way. But you don't have to click
            //     anything to 'fire'(call/execute) it. The 'gamePictureBox_Paint' event method is called  
            //     automagically when windows(!) decides that the graphics of the gamePictureBox are 'dirty'
            //     and are in need of repainting. This hapens for example when you minimize and maximize 
            //     your application in Windows. Or if a user drags another window over your gamePictureBox object
            //     when using the Windows UI. 
            //
            //     You can also FORCE the paint event method to be called. 
            //     And thus force refreshing your screen... And thus show game updates or create animations.
            //     This can be done by calling the Refresh() method of the UI widget that has to be repainted.
            //     So in this case: calling "gamePictureBox.Refresh();" will trigger a call to the
            //     gamePictureBox_Paint(...) event method. Which updates the graphics of the gamePictureBox
            //     by using (custom )drawing instructions/commands.
            //
            //     Finding the missing link between event and (event)method:
            //     You can lookup event methods of UI objects in the Designer view of visual studio.
            //     For example: doubleclick on the MainForm.cs file in the Solution explorer. 
            //     And then select the topmost button in the designed UI of the application.
            //     The Propery window of the GUI editor will then show you the properties of the button (e.g. Name: moveButton).
            //     By pressing the lightning bolt of the Property Window, all events and coupled event methods are shown.
            //     So select the lightning bolt and scroll down to find the Click event. What do you see?
            //     The same can be done for the gamePictureBox object. Can you find the Paint event by using the 
            //     Property window of the gamePictureBox object? Which method is coupled to the Paint event 
            //     according to the Property explorer?
            //      
            //     Questions? Ask the teacher.
            //
            //     PS: you dont have to couple the paint event by using the UI editor, as is done in this example. You can also code :
            //     gamePictureBox.Paint += new PaintEventHandler(gamePictureBox_Paint);
            //     in the constructor to connect the event method gamePictureBox_Paint to the Paint event of gamePictureBox.
            //

            // Ok, enough 'talk' lets do stuff...
            //
            // First: Get a grab of the Graphics object passed in the parameter 'e'of the paont event method.
            // You need it to mess around with the graphics of the PictureBox we are going to paint on.
            Graphics canvas = e.Graphics;   // Smart variable name :)... its actually like painting on a canvas.

            // Now... draw something (Remember,  this is all just example code to show off custom drawing
            //                        it will not earn prices for best coding coding habits :)).
            // See https://docs.microsoft.com/en-us/dotnet/api/system.drawing.graphics
            canvas.DrawRectangle(Pens.Black, 100, 50, 10, 10);
            canvas.FillRectangle(Brushes.Black, 150, 50, 10, 10);

            // You can put logic in the method too (yes, you can just program like you're used to)
            if (isDrawingFace)
            {
                canvas.FillEllipse(Brushes.Yellow, 125, 80, 40, 40);
                canvas.FillEllipse(Brushes.Black, 130, 90, 10, 10);
                canvas.FillEllipse(Brushes.Black, 150, 90, 10, 10);
                canvas.FillEllipse(Brushes.Black, 132, 105, 26, 10);
                // Ai, what a lot of hardcoded numbers... ugh (don't do this at home)
                // And also.... no points for nice graphics :)
            }

            // Draw another rectangle of which the position is changed by clicking a button
            canvas.FillRectangle(Brushes.Black, movingRectanglePosition.X, movingRectanglePosition.Y, 10, 10);


            // Hint: of course you can put your drawing code in seperate classes too.
            // For example: Making a Face class which contains a DrawTo(Graphics canvas) method that can draw the Face 
            // to the canvas (parameter) is much nicer.
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            // Just an example of calling Refresh after changing the 'game' state.

            movingRectanglePosition.X += 5;
            gamePictureBox.Refresh(); // Force calling the paint event method gamePictureBox_Paint, 
                                      // See comments in gamePictureBox_Paint.

            // Ok what a fun pressing the button many times. Votes for using a Timer object, anyone?
            // Do a Find on 'Timer' in this file and find out how.

            // Please note: all drawing code is in gamePictureBox_Paint, not in this method.
            // This method only changes the state of the program/game. And then calls Refresh
            // to make the update visible to the user.
        }

        private void faceButton_Click(object sender, EventArgs e)
        {
            // Just another example of calling Refresh after changing the 'game' state.

            // Because 'drawface' is changed, the behaviour of gamePictureBox_Paint is changed. 
            isDrawingFace = !isDrawingFace;
            gamePictureBox.Refresh();

            // Please note: all drawing code is in gamePictureBox_Paint, not in this method.
            // This method only changes the state of the program/game. And then calls Refresh
            // to make the update visible to the user.
        }

        private void SetupTimer(Timer timer)
        {
            // Hint: Please read / use / learn about timers only after your read about custom drawing in the other methods of this file.
            const int interval = (int)(1000 / 30.0); 
            timer.Interval = interval;    // Set the interval for generating a timer Tick, 30 times a second.
            timer.Tick += gameTimer_Tick; // Couple the gameTimer_Tick method to the Tick event of the timer
                                          // (lookup the gameTimer_Tick method in this file to see what it is doing)
            timer.Start();                // Start the timer (which then fires Tick events on the interval that was set)
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Do usefull things over here :)");

            // Not much done here at the moment. Woud expect usefull things here to update the gameworld data

            // Enforce a  repaint of the picture box by calling its Refresh method.
            // Note: do not put paining code here. Painting code must be only present in (or called from) the paint event method 
            //       (in this case the method gamePictureBox_Paint(object sender, PaintEventArgs e))
            gamePictureBox.Refresh();
        }
    }
}
