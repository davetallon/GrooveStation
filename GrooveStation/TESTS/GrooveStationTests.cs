using NUnit.Framework;
using WMPLib;

namespace GrooveStation.Tests
{
    public class GrooveStationTests
    {
        [Test]
        public void PlayTrack_SelectedSongNotNull_TrackPlays()
        {
            // Arrange
            var form = new GrooveStationClass();
            var player = form.Player;
            form.selectedSong = "song.mp3";

            // Act
            form.PlayTrack();

            // Assert
            Assert.That(WMPPlayState.wmppsPlaying, Is.Not.Null);         
        }

        [Test]
        public void PauseTrack_TrackPlaying_TrackPauses()
        {
            // Arrange
            var form = new GrooveStationClass();
            form.Player.Ctlcontrols.play();

            // Act
            form.PauseTrack();

            // Assert
            Assert.That(WMPPlayState.wmppsPaused, Is.Not.Null);
        }

        [Test]
        public void AdjustViewState_Play_TrackViewStateAdjusted()
        {
            // Arrange
            var form = new GrooveStationClass();

            // Act
            form.AdjustViewState("Play");

            // Assert
            Assert.That(form.pb_Pause.Visible);
            Assert.That(!form.pb_PlayPause.Visible);
            Assert.That(form.pb_Headphones_Playing.Visible);
            Assert.That(form.pb_valvesPlaying.Visible);
        }
    }
}
