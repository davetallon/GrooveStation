using GrooveStation.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GrooveStation.PRESENTER
{
    public class MusicControlsPresenter : LoadTracks, IPresenterControlls
    {
        //EVENTS
        public event EventHandler MusicLoaded;


        //PROPERTIES
        public List<Track> tracklist = new List<Track>();


        //EVENT HANDLERS
        public void onLoadingMusic(string type)
        {
            switch (type)
                {
                case "Local":
                    tracklist = LoadLocalSongs();
                    break;

                case "Spotify":
                    tracklist = LoadSpotifySongs();
                    break;
                }
            MusicLoaded?.Invoke(this, new EventArgs());
        }

        public Bitmap onRotateImage(Image image, PointF offset, float angle)
        {
            //CREATE NEW EMPTY BITMAP TO HOLD ROTATED IMAGE.
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //MAKE A GRAPHICS OBJECT FROM THE EMPTY BITMAP
            Graphics g = Graphics.FromImage(rotatedBmp);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //PUT THE ROTATION POINT IN THE CENTER OF IMAGE
            g.TranslateTransform(offset.X, offset.Y);

            //ROTATE THE IMAGE
            g.RotateTransform(angle);

            //MOVE THE IMAGE BACK 
            g.TranslateTransform(-offset.X, -offset.Y);

            //DRAW PASSED IN IMAGE ONTO GRAPHICS OBJECT
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }
    }
}