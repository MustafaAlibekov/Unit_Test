//подключение библиотек
#include <opencv2/core/core.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <string>
//использование пространств имен
using namespace cv;
using namespace std;
int main()
{
	// высота и ширина
	int height = 520;
	int width = 820;
	// загрузка изображения с помощью матрицы
	Mat img(height, width, CV_8UC3);
	Point textOrg(100, img.rows / 2);//Местоположение. 
	Point textOrg1(500, img.rows / 2);//Местоположение. 
	Point textOrg2(300, img.rows / 2);//Местоположение. 
	int fontFace = FONT_HERSHEY_TRIPLEX;//шрифт
	double fontScale = 2;//Его масштаб, размер.
	Scalar color(255, 20, 147);//Цвет текста.
	//Далее выполняется отрисовка фразы из переменной 
	//text в изображение img в положение textOrg.
	//Фонт/гарнитура задается следующими переменными: 
	//fontFace, fontScale, thickness. putText(img, text, textOrg, fontFace, fontScale, color); 
	putText(img, "good", textOrg, fontFace, fontScale, color);
	putText(img, "morning", textOrg1, fontFace, fontScale, color);
	putText(img, "('_')", textOrg2, fontFace, fontScale, color);
	putText(img, "", textOrg, fontFace, fontScale, color);
	putText(img, "", textOrg, fontFace, fontScale, color);
	namedWindow("Hello world", 0);//название окна
	imshow("Hello world", img);
	waitKey(0);
	return 0;
}
