using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Cafe
{
    //класс для взаимодействия базы данных и изображений 
    public class DBImage
    {

        //загрузка изображения из базы данных
        public static Image LoadImage(byte[] imageData)
        {


            Image image;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }



        public static SqlParameter uploadImage(Bitmap image)
        {

           // var image = new Bitmap(pictureBox1.Image);
            using (var memoryStream = new MemoryStream())
            {
               
                    image.Save(memoryStream, ImageFormat.Jpeg);
                    memoryStream.Position = 0;
                    var param = new SqlParameter("@изображение", SqlDbType.VarBinary, (int)memoryStream.Length)
                    {
                        Value = memoryStream.ToArray()
                    };

                    image.Dispose();
                    memoryStream.Dispose();

                         return param;
                
              

            }
       


        }


        public static SqlParameter uploadImage2(PictureBox pictureBox)
        {
            
           
            // Преобразуем изображение в массив байтов
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                using (Image image = pictureBox.Image)
                {
                    Image img = image;


                    image.Save(ms, img.RawFormat);
                }
                imageBytes = ms.ToArray();
            }

            SqlParameter imageParameter = new SqlParameter("@изображение", SqlDbType.Image);
            imageParameter.Value = imageBytes;

            return imageParameter;
        }





    }







}
