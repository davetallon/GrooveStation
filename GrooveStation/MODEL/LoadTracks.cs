using GrooveStation.MODEL.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GrooveStation.MODEL
{
    public class LoadTracks : ILocalSongInput, ISpotifyInput
    {
        public List<Track> LoadLocalSongs() 
        {
            // 'Using' keyword ensures disposal of data when complete.
            using (OpenFileDialog open = new OpenFileDialog())
            {
                List<Track> playlist = new List<Track>();
                string[] filePath;
                string[] fileContent;
                open.Filter = "Audio files (*.mp3;*.wav)|*.mp3;*.wav|All files (*.*)|*.*";
                open.InitialDirectory = @"C:\";
                open.Title = "Load Grooves...";
                open.Multiselect = true;
                open.ShowDialog();
                filePath = open.FileNames;
                fileContent = open.FileNames;

                //Loop through the opened files and use the Playlist class to unpack the data.
                for (int i = 0; i < fileContent.Length; i++)
                {
                    Track trackToAdd = new Track();
                    trackToAdd.PlaylistID = i;
                    trackToAdd.TrackTitle = fileContent[i].Substring(fileContent[i].LastIndexOf("\\") + 1);
                    trackToAdd.TrackAddress = fileContent[i];
                    trackToAdd.Runtime = fileContent[i]; //This is unpacked in the VIEW layer using IWMP newMedia()
                    playlist.Add(trackToAdd);
                }
                return playlist;
            }
        }

        public List<Track> LoadSpotifySongs()
        {
            //THIS SPOTIFY WORK IS PLACEHOLDER. TBC IN NEXT ITERATION.

            List<Track> playlist = new List<Track>();
            return playlist;
        }
    }
}