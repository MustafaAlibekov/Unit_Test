#include <opencv2/core/core.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <string>
using namespace cv;
using namespace std;
int main()
{
	int height = 520;
	int width = 820;
	Mat img(height, width, CV_8UC3);
	Point textOrg(100, img.rows / 2);
	Point textOrg1(500, img.rows / 2);
	Point textOrg2(300, img.rows / 2);
	int fontFace = FONT_HERSHEY_TRIPLEX;
	double fontScale = 2;
	Scalar color(255, 20, 147);
	putText(img, "good", textOrg, fontFace, fontScale, color);
	putText(img, "morning", textOrg1, fontFace, fontScale, color);
	putText(img, "('_')", textOrg2, fontFace, fontScale, color);
	putText(img, "", textOrg, fontFace, fontScale, color);
	putText(img, "", textOrg, fontFace, fontScale, color);
	namedWindow("Hello world", 0);
	imshow("Hello world", img);
	waitKey(0);
	return 0;
}
