using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GrooveStation_HARDWARE.Tests
{
    [TestFixture]
    public class HardwareInterfaceTests
    {
        private HardwareInterface hardwareInterface;

        [SetUp]
        public void Setup()
        {
            hardwareInterface = new HardwareInterface();
        }

        [Test]
        public void BrowseButton_Click_OpenFileDialogIsShown()
        {
            // Arrange
            OpenFileDialog openFileDialog = null;
            hardwareInterface.Shown += (sender, e) =>
            {
                openFileDialog = new OpenFileDialog();
                openFileDialog.FileName = "test.mp3";
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Multiselect = true;
                openFileDialog.ShowDialog();
            };

            // Act
            hardwareInterface.btn_Browse_Click(null, EventArgs.Empty);

            // Assert
            Assert.That(openFileDialog, Is.Not.Null);
        }

        [Test]
        public void ShuffleButton_Click_PlaylistIsShuffled()
        {
            // Arrange
            List<Track> originalPlaylist = new List<Track>
            {
                new Track { PlaylistID = 1, TrackTitle = "Song 1", TrackAddress = "C:\\Songs\\song1.mp3", Runtime = "3:45" },
                new Track { PlaylistID = 2, TrackTitle = "Song 2", TrackAddress = "C:\\Songs\\song2.mp3", Runtime = "4:12" },
                new Track { PlaylistID = 3, TrackTitle = "Song 3", TrackAddress = "C:\\Songs\\song3.mp3", Runtime = "3:20" }
            };
            hardwareInterface.playlist = originalPlaylist;

            // Act
            hardwareInterface.btn_Shuffle_Click(null, EventArgs.Empty);

            // Assert
            List<Track> shuffledPlaylist = hardwareInterface.lb_FilePath.DataSource as List<Track>;
            Assert.That(shuffledPlaylist, Is.Not.Null);
            CollectionAssert.AreNotEqual(originalPlaylist, shuffledPlaylist);
        }
    }
}
