using Plugin.MediaManager.Abstractions;
using Plugin.MediaManager.Abstractions.Implementations;

namespace Plugin.MediaManager
{
    [Android.Runtime.Preserve(AllMembers = true)]
    public class MediaManagerImplementation : MediaManagerBase
    {
        public override IAudioPlayer AudioPlayer { get; set; } = new AudioPlayerImplementation();
        public override IVideoPlayer VideoPlayer { get; set; } = new VideoPlayerImplementation();
        public override IMediaNotificationManager MediaNotificationManager { get; set; }
        public override IMediaExtractor MediaExtractor { get; set; } = new MediaExtractorImplementation();
    }
}