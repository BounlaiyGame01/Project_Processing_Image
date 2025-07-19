using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Imageprocess
{
    public partial class Form3 : Form
    {
        Image<Gray, byte> grayVDO, binaryVDO;
        VideoCapture capture = null;
        Mat Frame = new Mat();
        bool camerraRunning = false;
        public Form3()
        {
            InitializeComponent();
        }


        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image != null)
            {
                imageBox1.Image = ((Mat)imageBox1.Image).ToImage<Bgr, Byte>().Clone();
                imageBox2.Image = imageBox1.Image;

            }
        }

        private void btnStartWeb_Click(object sender, EventArgs e)
        {
            try
            {
                if (camerraRunning == false)
                {
                    capture = new VideoCapture(0);
                    capture.ImageGrabbed += Capture_ImageGrabbed;
                    capture.Start();
                    camerraRunning = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error starting camerra:" + ex.Message);
            }
        }

        private void Capture_ImageGrabbed(object? sender, EventArgs e)
        {
            if (capture != null && capture.Ptr != IntPtr.Zero)
            {
                capture.Retrieve(Frame);
                imageBox1.Image = Frame;
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            camerraRunning = false;
            capture = new VideoCapture(0);
            Frame = new Mat();
        }

        private void btnStipWeb_Click(object sender, EventArgs e)
        {
            capture.Stop();
            capture.Dispose();
            capture = null;
            camerraRunning = false;
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
            {
                MessageBox.Show("Please load or capture an image first.");
                return;
            }

            if (cbFilter.SelectedItem == null)
            {
                MessageBox.Show("Please select a histogram method.");
                return;
            }

            Image<Bgr, byte> ori;

            // Handle different image types safely
            if (imageBox1.Image is Mat mat)
            {
                ori = mat.ToImage<Bgr, byte>();
            }
            else if (imageBox1.Image is Image<Bgr, byte> img)
            {
                ori = img;
            }
            else
            {
                MessageBox.Show("Unsupported image type.");
                return;
            }

            // Convert to grayscale for processing only
            Image<Gray, byte> gray = ori.Convert<Gray, byte>();
            Image<Gray, byte> result = new Image<Gray, byte>(gray.Width, gray.Height);

            string method = cbFilter.SelectedItem.ToString();

            switch (method)
            {
                case "Equalize":
                    CvInvoke.EqualizeHist(gray, result);
                    break;

                case "Gaussian":
                    CvInvoke.GaussianBlur(gray, result, new Size(7, 7), 0);
                    break;

                case "Median":
                    CvInvoke.MedianBlur(gray, result, 7);
                    break;

                default:
                    MessageBox.Show("Unknown method.");
                    return;
            }

            // Show processed result in grayscale
            imageBox2.Image = result;

            // ✅ Show grayscale histogram from imageBox2
            if (imageBox2.Image is Image<Gray, byte> grayResult)
            {
                DenseHistogram grayHist = new DenseHistogram(256, new RangeF(0, 256));
                grayHist.Calculate(new Image<Gray, byte>[] { grayResult }, false, null);

                histogramBox1.ClearHistogram();
                histogramBox1.GenerateHistograms(grayResult, 256);
                histogramBox1.Refresh();
            }
            else
            {
                MessageBox.Show("The image in imageBox2 is not in grayscale format.");
            }

        }

        private void btnMorphology1_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
            {
                MessageBox.Show("Please load or capture an image first.");
                return;
            }

            if (cbMorphology.SelectedItem == null)
            {
                MessageBox.Show("Please select a morphology operation.");
                return;
            }

            // Convert image to usable format
            Image<Bgr, byte> inputImage;
            if (imageBox1.Image is Mat mat)
            {
                inputImage = mat.ToImage<Bgr, byte>();
            }
            else if (imageBox1.Image is Image<Bgr, byte> img)
            {
                inputImage = img.Clone();
            }
            else
            {
                MessageBox.Show("Unsupported image type.");
                return;
            }

            // Convert to binary
            Image<Gray, byte> binaryImage = inputImage.Convert<Gray, byte>()
                                                       .ThresholdBinaryInv(new Gray(150), new Gray(255));

            // Create structuring element
            Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));

            // Result image
            Image<Gray, byte> morphoImage = null;

            // Apply morphology based on selected item
            string selected = cbMorphology.SelectedItem.ToString();

            switch (selected)
            {
                case "Erosion":
                    morphoImage = binaryImage.Erode(1);
                    break;

                case "Dilation":
                    morphoImage = binaryImage.Dilate(1);
                    break;

                case "Gradient":
                    morphoImage = binaryImage.MorphologyEx(MorphOp.Gradient, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                    break;

                case "Top Hat":
                    morphoImage = binaryImage.MorphologyEx(MorphOp.Tophat, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                    break;

                case "Black Hat":
                    morphoImage = binaryImage.MorphologyEx(MorphOp.Blackhat, kernel, new Point(-1, -1), 1, BorderType.Default, new MCvScalar(1.0));
                    break;

                default:
                    MessageBox.Show("Please select a valid morphology operation.");
                    return;
            }

            // Show result
            imageBox2.Image = morphoImage;
        }

        private void cbMorphology_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEDetection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load image from file
                        Image<Bgr, byte> img = new Image<Bgr, byte>(ofd.FileName);

                        // Show in imageBox1
                        imageBox1.Image = img;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to load image: " + ex.Message);
                    }
                }
            }
        }

        private void btn_BasicProcessing_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
            {
                MessageBox.Show("Please load or capture an image first.");
                return;
            }

            // Handle both Mat and Image<Bgr, byte>
            Image<Bgr, byte> oriImage;
            if (imageBox1.Image is Mat mat)
            {
                oriImage = mat.ToImage<Bgr, byte>();
            }
            else if (imageBox1.Image is Image<Bgr, byte> img)
            {
                oriImage = img;
            }
            else
            {
                MessageBox.Show("Unsupported image format.");
                return;
            }

            // Convert to grayscale
            Image<Gray, byte> gray = oriImage.Convert<Gray, byte>();
            Image<Gray, byte> result;

            switch (cbBinary.SelectedIndex)
            {
                case 0: // Binary
                    result = gray.ThresholdBinary(new Gray(100), new Gray(255));
                    break;
                case 1: // Binary Invert
                    result = gray.ThresholdBinaryInv(new Gray(100), new Gray(255));
                    break;
                case 2: // Threshold To Zero
                    result = gray.ThresholdToZero(new Gray(100));
                    break;
                case 3: // Adaptive Gaussian
                    result = gray.ThresholdAdaptive(new Gray(255),
                        AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 9, new Gray(0));
                    break;
                case 4: // Adaptive Mean
                    result = gray.ThresholdAdaptive(new Gray(255),
                        AdaptiveThresholdType.MeanC, ThresholdType.Binary, 9, new Gray(0));
                    break;
                default:
                    MessageBox.Show("Please select a thresholding method from the list.");
                    return;
            }

            imageBox2.Image = result;
        }

        private void btnEDetection_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image == null)
            {
                MessageBox.Show("Please load or capture an image first.");
                return;
            }

            Image<Bgr, byte> oriImage;

            if (imageBox1.Image is Mat mat)
                oriImage = mat.ToImage<Bgr, byte>();
            else if (imageBox1.Image is Image<Bgr, byte> img)
                oriImage = img;
            else
            {
                MessageBox.Show("Unsupported image format.");
                return;
            }

            string method = cbEDetection.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(method))
            {
                MessageBox.Show("Please select an edge detection method.");
                return;
            }

            Image<Gray, byte> grayImage = oriImage.Convert<Gray, byte>();
            Image<Gray, byte> result = null;

            switch (method)
            {
                case "Canny":
                    result = grayImage.Canny(100, 200); // You can adjust thresholds
                    break;

                case "Laplacian":
                    Mat laplaceMat = new Mat();
                    CvInvoke.Laplacian(grayImage, laplaceMat, DepthType.Cv16S, 3, 1, 0, BorderType.Default);
                    result = laplaceMat.ToImage<Gray, short>().Convert<Gray, byte>();
                    break;

                case "Sobel":
                    Mat sobelMat = new Mat();
                    CvInvoke.Sobel(grayImage, sobelMat, DepthType.Cv16S, 1, 1, 3);
                    result = sobelMat.ToImage<Gray, short>().Convert<Gray, byte>();
                    break;

                default:
                    MessageBox.Show("Invalid method.");
                    return;
            }

            imageBox2.Image = result;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (imageBox1.Image != null)
            {
                imageBox2.Image = imageBox1.Image;
            }
            else
            {
                MessageBox.Show("No original image to reset to.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (imageBox2.Image == null)
            {
                MessageBox.Show("No processed image to save.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                sfd.Title = "Save Processed Image";
                sfd.FileName = "processed_image";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Convert and save
                        if (imageBox2.Image is Image<Bgr, byte> imgBgr)
                        {
                            imgBgr.Save(sfd.FileName);
                        }
                        else if (imageBox2.Image is Image<Gray, byte> imgGray)
                        {
                            imgGray.Save(sfd.FileName);
                        }
                        else if (imageBox2.Image is Mat mat)
                        {
                            mat.Save(sfd.FileName);
                        }
                        else
                        {
                            MessageBox.Show("Unsupported image format.");
                        }

                        MessageBox.Show("Image saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving image: " + ex.Message);
                    }
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
