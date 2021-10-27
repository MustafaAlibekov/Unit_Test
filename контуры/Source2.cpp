#include <opencv2/core/core.hpp>
#include <opencv2/imgproc/imgproc.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <string>
#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <windows.h>
using namespace cv;
using namespace std;
int main()
{
	setlocale(LC_ALL, "Russian");
	char filename[80]; //Luffy_Anime_Post_Timeskip_Infobox.jpg(имя файла)
	cout << "Ââåäèòå èìÿ ôàéëà, â êîòîðûé õîòèòå âíåñòè èçìåíåíèÿ è íàæìèòå Enter" << endl;
	cin.getline(filename, 80);
	cout << filename << endl;
	Mat img = imread(filename, 1);
	namedWindow("Èñõîäíîå èçîáðàæåíèå" , WINDOW_AUTOSIZE);// название окна
	imshow("Èñõîäíîå èçîáðàæåíèå", img);//imshow(I, [low high]) отображает полутоновое изображение, указывая диапазон отображения как двухэлементный вектор, [low high]
	Mat src_gray; Mat canny_output;// Размытие здесь просто для того, чтобы нарушить исходное изображение, это необязательно, функция Canny реализовала пять шагов своего алгоритма
        blur(gray, gray_blur, Size(3, 3), Point(-1, -1), BORDER_DEFAULT);
		cvtColor(img, src_gray, COLOR_RGB2GRAY);
	blur(src_gray, src_gray, Size(3, 3));
	double otsu_thresh_val = threshold(src_gray, img, 0, 255, THRESH_BINARY | THRESH_OTSU);
	double high_thresh_val = otsu_thresh_val, lower_thresh_val=otsu_thresh_val * 0.5;
	cout << otsu_thresh_val;
	Canny(src_gray, canny_output, lower_thresh_val, high_thresh_val, 3);
	namedWindow("Ñåðîå èçîáðàæåíèå", WINDOW_AUTOSIZE);//название окна
	imshow("Ñåðîå èçîáðàæåíèå", canny_output);
	imwrite("canny_output.jpg", canny_output);
	waitKey(0);
	return 0;
}
