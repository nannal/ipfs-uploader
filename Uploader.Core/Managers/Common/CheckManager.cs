namespace Uploader.Core.Managers.Common
{
    public static class CheckManager
    {

        public static bool CheckFfmpeg()
        {
            var process = new ProcessManager("ffmpeg", "-version", LogManager.FfmpegLogger);
            bool success = process.Launch(1);
            if(!success)
                return false;

            if(process.DataOutput.ToString().StartsWith("ffmpeg version 3."))
            {
                return true;
            }

            return false;
        }

        public static bool CheckFfprobe()
        {
            var process = new ProcessManager("ffprobe", "-version", LogManager.FfmpegLogger);
            bool success = process.Launch(1);
            if(!success)
                return false;

            if(process.DataOutput.ToString().StartsWith("ffprobe version 3."))
            {
                return true;
            }

            return false;
        }

        public static bool CheckImageMagickComposite()
        {
            var process = new ProcessManager("C:\\ImageMagick\\composite", "-version", LogManager.SpriteLogger);
            bool success = process.Launch(1);
            if(!success)
                return false;

            if(process.DataOutput.ToString().StartsWith("Version: ImageMagick 7."))
            {
                return true;
            }

            return false;
        }

        public static bool CheckImageMagickConvert()
        {
            var process = new ProcessManager("C:\\ImageMagick\\convert", "-version", LogManager.SpriteLogger);
            bool success = process.Launch(1);
            if(!success)
                return false;

            if(process.DataOutput.ToString().StartsWith("Version: ImageMagick 7."))
            {
                return true;
            }

            return false;
        }
    }
}
