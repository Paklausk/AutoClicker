using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker.Objects
{
    public class AudioPlayer : IDisposable
    {
        public class LoopStream : MemoryStream
        {
            public LoopStream(byte[] buffer) : base(buffer)
            {
                this.EnableLooping = true;
            }
            public bool EnableLooping { get; set; }
            public override long Length
            {
                get { return long.MaxValue; }
            }
            public override long Position
            {
                get { return base.Position; }
                set { base.Position = value; }
            }
            public override int Read(byte[] buffer, int offset, int count)
            {
                int totalBytesRead = 0;

                while (totalBytesRead < count)
                {
                    int bytesRead = base.Read(buffer, offset + totalBytesRead, count - totalBytesRead);
                    if (bytesRead == 0)
                    {
                        if (base.Position == 0 || !EnableLooping)
                        {
                            // something wrong with the source stream
                            break;
                        }
                        base.Position = 0;
                    }
                    totalBytesRead += bytesRead;
                }
                return totalBytesRead;
            }
        }
        IWavePlayer _player = new WaveOut();
        StreamMediaFoundationReader _audio;
        public bool IsPlaying
        { get; private set; }
        public AudioPlayer()
        {
            _audio = new StreamMediaFoundationReader(new LoopStream(Properties.Resources.audio));
            _player.Init(_audio);
        }
        public void Play()
        {
            IsPlaying = true;
            _player.Play();
        }
        public void Stop()
        {
            IsPlaying = false;
            _player.Stop();
        }
        public void Dispose()
        {
            Stop();
            _audio.Dispose();
            _player.Dispose();
        }
    }
}
