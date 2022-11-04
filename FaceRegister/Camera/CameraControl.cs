using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRegister.Camera
{
    class CameraControl
    {
        private Capture capture = null;

        public void StreamVideo(string IPorURLCamera)
        {
            if (IPorURLCamera == "0" || string.IsNullOrEmpty(IPorURLCamera))
            {
                capture = new Capture(0);          
            }
            else
            {
                capture = new Capture(IPorURLCamera);
            }
        }

        public Bitmap GetImage()
        {
            if(capture == null)
            {
                return null;
            }
            try
            {
                Mat currentFrame = capture.QueryFrame();
                if (currentFrame == null)
                {
                    return null;
                }

                Image<Bgr, Byte> frame = currentFrame.ToImage<Bgr, Byte>();
                Bitmap frame_query = frame.Bitmap;
                return frame_query;
            }
            catch
            {
                return null;
            }
           
        }

        public void StopStream()
        {
            //capture.Dispose();
        }
    }
}
