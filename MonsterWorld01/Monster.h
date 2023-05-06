#pragma once
#include "Canvas.h"
#define DIM 40

class Monster 
{
	string name, icon;	// 몬스터 이름과 화면 출력용 아이콘
	int x, y, nItem;		// 현재 위치와 먹은 아이템 수
	int nEnergy;		// 에너지를 저장하는 속성

	void clip(int maxx, int maxy)	//위치
	{
		if (x < 0) x = 0;
		if (x >= maxx) x = maxx - 1;
		if (y < 0) y = 0;
		if (y >= maxy) y = maxy - 1;
	}
	void eat(int** map)		//먹은 아이템
	{
		if (map[y][x] == 1) 
		{
			map[y][x] = 0;
			nItem++;
			nEnergy += 8;
		}
		else if(map[y][x] == 0)
		{
			if(nEnergy > 0)
				nEnergy--;
		}
	}
public:
	Monster(string n = "      ", string i = "  ", int px = 0, int py = 0)
		: name(n), icon(i), x(px), y(py), nItem(0) ,nEnergy(100){}			//멤버 초기화 리스트를 이용하여 에너지 초기화
	~Monster() { cout << "\t" << name << icon << " 물러갑니다~~~\n"; }

	int getEnergy(int Monster[5])
	{
		return Monster[5];
	}

	void draw(Canvas& canvas) { canvas.draw(x, y, icon); }
	void move(int** map, int maxx, int maxy) 
	{
		switch (rand() % 8) 
		{
		case 0: y--; break;
		case 1: x++; y--; break;
		case 2: x++; break;
		case 3: x++; y++; break;
		case 4: y++; break;
		case 5: x--; y++; break;
		case 6: x--; break;
		case 7: x--; y--; break;
		}
		clip(maxx, maxy);
		eat(map);
	}
	void print() { cout << "\t" << name << icon << ":" << nItem << " E:" << nEnergy << endl; } //에너지도 출력
};