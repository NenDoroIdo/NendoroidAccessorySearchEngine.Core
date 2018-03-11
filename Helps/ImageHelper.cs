using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Nendoroido.Core.Helps
{
    class ImageHelper
    {
        /// <summary>
        /// Convert from byte to image
        /// https://stackoverflow.com/questions/29153967/convert-a-byte-into-an-emgu-opencv-image
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Image<Gray, byte> ConvertFromByte(byte[] bytes, int width, int height)
        {
            Image<Gray, byte> depthImage = new Image<Gray, byte>(width, height);
            depthImage.Bytes = bytes;
            return depthImage;
        }
    }
}
