#include <iostream.h>
#include <conio.h>
#include <graphics.h>
#include <stdlib.h>
#include <dos.h>
void main()
{
	int k = 0;
	int i = 0;
	int gd = DETECT, gm;
	int x2 = 200, y2 = 340;
	int x3 = 450, y3 = 140;
	int l = 0;
	int j = 0;
	int xxx, yyy;
	int barx1 = 10, bary1 = 230, barx2 = 80, bary2 = 250;
	int a, b;
	int emtiaz = 0;
	initgraph(&gd, &gm, "c:\\turboc3\\bgi");
	cleardevice();
	while (!kbhit())
		putpixel(random(640), random(480), random(16));
	cleardevice();
	setcolor(1);
	settextstyle(4, 0, 2);
	outtextxy(230, 15, "in the name of god..");
	setcolor(2);
	settextstyle(10, 0, 2);
	outtextxy(110, 240, "created by behrad ravanbod");
	setcolor(4);
	settextstyle(10, 0, 2);
	outtextxy(150, 400, "to forward, press ->");
	sleep(3);
	cleardevice();
	setcolor(14);
	line(0, 120, 639, 120);
	line(0, 360, 639, 360);
	setcolor(7);
	circle(200, 410, 50);
	circle(450, 70, 50);
	setfillstyle(1, 1);
	bar(barx1, bary1, barx2, bary2);
	while (k != 27)
	{
		while (!kbhit())
		{
			setcolor(0);
			circle(x2, y2, 2);
			y2 = y2 + j;
			setcolor(2);
			circle(x2, y2, 2);
			delay(2);
			if (y2 == 140)
			{
				y2 = 340;
				setfillstyle(1, 0);
				bar(190, 138, 210, 142);
			}
			if ((x2 >= barx1) && (x2 <= barx2) && (y2 + 2 == bary2))
			{
				for (int boom = 2; boom <= 20; boom++)
				{
					setcolor(4);
					delay(2);
					circle(x2, y2, boom);
				}
				settextstyle(0, 0, 0);
				outtextxy(x2 + 15, y2 + 10, "BOOM");
				sound(100);
				sleep(1);
				cleardevice();
				settextstyle(4, 0, 3);
				outtextxy(316, 240, "game over");
				sleep(3);
				closegraph();
				delay(2);
				nosound();
			}
			if ((x3 <= barx2) && (x3 >= barx1) && (y3 + 2 == bary1))
			{
				for (int boom = 2; boom <= 20; boom++)
				{
					setcolor(4);
					delay(2);
					circle(x3, y3, boom);
				}
				settextstyle(0, 0, 0);
				outtextxy(x3 + 15, y3 + 10, "BOOM");
				sound(100);
				sleep(1);
				cleardevice();
				settextstyle(4, 0, 3);
				outtextxy(316, 240, "game over");
				sleep(3);
				closegraph();
				nosound();
			}
			if (barx2 == 640)
			{
				barx1 = 10;
				bary1 = 230;
				barx2 = 80;
				bary2 = 250;
				emtiaz++;
				cout << emtiaz << endl;
			}
			if (emtiaz == 2)
			{
				i++;
				cleardevice();
				settextstyle(0, 0, 0);
				outtextxy(320, 240, "rafti marhale bad");
				sleep(1);
				cleardevice();
				barx1 = 10;
				bary1 = 230;
				barx2 = 80;
				bary2 = 250;
				l = l + 1;
				j = j - 1;
				emtiaz = 0;
				setcolor(14);
				line(0, 120, 639, 120);
				line(0, 360, 639, 360);
				setcolor(7);
				circle(200, 410, 50);
				circle(450, 70, 50);
			}
			setcolor(0);
			circle(x3, y3, 2);
			y3 = y3 + l;
			setcolor(2);
			circle(x3, y3, 2);
			delay(2);
			if (y3 == 340)
			{
				y3 = 140;
				setfillstyle(1, 0);
				bar(440, 338, 4460, 342);
			}
		}

		setfillstyle(1, 0);
		bar(a, bary1, b, bary2);
		setfillstyle(1, 1);
		bar(barx1, bary1, barx2, bary2);
		a = barx1;
		b = barx2;
		k = getch();
		if (k == 77)
		{
			barx1 += 10;
			barx2 += 10;
		}
	}
}