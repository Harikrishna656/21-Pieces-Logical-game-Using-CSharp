using System.Media;
namespace _21pieces
{
    class souds
    {
        SoundPlayer music = new SoundPlayer();
        public void Homemusic_play()
        {
            music.SoundLocation = @"C:\Users\AssassiN\source\musics\Wallpaper.wav";
            music.Play();
            
        }
        public void Homemusic_pause()
        {
            music.Stop();
        }
        public void single_play()
        {
            music.SoundLocation = @"C:\Users\AssassiN\source\musics\Monkeys-Spinning.wav";
            music.Play();
        }
        public void single_pause()
        {
            music.Stop();
        }
        public void btn_pre_play()
        {
            music.SoundLocation = @"C:\Users\AssassiN\source\musics\btn_pre.wav";
            music.Play();
        }
        public void btn_options_play()
        {
            music.SoundLocation = @"C:\Users\AssassiN\source\musics\btn_option.wav";
            music.Play();

        }
        public void btn_next_play()
        {
            music.SoundLocation = @"C:\Users\AssassiN\source\musics\btn_next.wav";
            music.Play();
        }
    }
}
