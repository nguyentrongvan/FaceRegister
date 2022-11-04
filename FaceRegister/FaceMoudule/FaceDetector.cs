using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaceRecognitionDotNet;
using DlibDotNet;
using System.Drawing.Imaging;

namespace FaceRegister.FaceMoudule
{
    class FaceDetector
    {
        private static FrontalFaceDetector detector = Dlib.GetFrontalFaceDetector();

        public static Bitmap detectFace(Bitmap imageFrame)
        {
            Image<Bgr, Byte> imageCV = new Image<Bgr, byte>(imageFrame);
            Mat mat = imageCV.Mat;
            var array = new byte[mat.Width * mat.Height * mat.ElementSize];
            mat.CopyTo(array);

            using (Array2D<BgrPixel> img = Dlib.LoadImageData<BgrPixel>(array, (uint)mat.Height, (uint)mat.Width, (uint)(mat.Width * mat.ElementSize)))
            {
                Dlib.PyramidUp(img);
                DlibDotNet.Rectangle [] dets = detector.Operator(img);
                if(dets.Length == 0)
                {
                    return null;
                }

                DlibDotNet.Rectangle maxFace = getFaceWithMaxBBox(dets);
                System.Drawing.Rectangle face_crop = new System.Drawing.Rectangle();

                DlibDotNet.Point scale_topLeft = scaleCoordinate(maxFace.TopLeft, imageFrame, img.Rows, img.Columns);
                DlibDotNet.Point scale_bottomRight = scaleCoordinate(maxFace.BottomRight, imageFrame, img.Rows, img.Columns);

                face_crop.X = scale_topLeft.X;
                face_crop.Y = scale_topLeft.Y;

                face_crop.Width = scale_bottomRight.X;
                face_crop.Height = scale_bottomRight.Y;

                Console.WriteLine(face_crop);
                System.Drawing.Rectangle srcRect = new System.Drawing.Rectangle(0, 0 , imageFrame.Width, imageFrame.Height);
                Bitmap target = new Bitmap(face_crop.Width - face_crop.X, face_crop.Height - face_crop.Y);
              
                for (int i = face_crop.X; i < face_crop.Width; i++)
                {
                    for (int j = face_crop.Y; j < face_crop.Height; j++)
                    {
                        var pixel = imageFrame.GetPixel(i, j);
                        target.SetPixel(i - face_crop.X, j - face_crop.Y, pixel);
                    }
                }

                //string pathsave = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".jpg";
                //target.Save(pathsave);
                return target;
            }        
        }

        public static DlibDotNet.Rectangle getFaceWithMaxBBox(DlibDotNet.Rectangle[] face_dets)
        {
            decimal maxArea = 0;
            DlibDotNet.Rectangle maxFace = new DlibDotNet.Rectangle();

            foreach (var face in face_dets)
            {
               if(face.Area > maxArea)
                {
                    maxArea = face.Area;
                    maxFace = face;
                }
            }

            return maxFace;
        }

        private static DlibDotNet.Point scaleCoordinate(DlibDotNet.Point coord, Bitmap imgSrc, int row, int columns)
        {
            DlibDotNet.Point new_coord = new DlibDotNet.Point();
            int X = (coord.X * imgSrc.Width) / columns;
            int Y = (coord.Y * imgSrc.Height) / row;

            new_coord.X = X;
            new_coord.Y = Y;
            return new_coord;
        }

        private static bool isFaceDetected()
        {
            return false;
        }
    }
}
