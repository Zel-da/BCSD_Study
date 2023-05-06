#pragma once
#include "Canvas.h"
#define DIM 40

class Monster 
{
	string name, icon;	// ���� �̸��� ȭ�� ��¿� ������
	int x, y, nItem;		// ���� ��ġ�� ���� ������ ��
	int nEnergy;		// �������� �����ϴ� �Ӽ�

	void clip(int maxx, int maxy)	//��ġ
	{
		if (x < 0) x = 0;
		if (x >= maxx) x = maxx - 1;
		if (y < 0) y = 0;
		if (y >= maxy) y = maxy - 1;
	}
	void eat(int** map)		//���� ������
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
		: name(n), icon(i), x(px), y(py), nItem(0) ,nEnergy(100){}			//��� �ʱ�ȭ ����Ʈ�� �̿��Ͽ� ������ �ʱ�ȭ
	~Monster() { cout << "\t" << name << icon << " �������ϴ�~~~\n"; }

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
	void print() { cout << "\t" << name << icon << ":" << nItem << " E:" << nEnergy << endl; } //�������� ���
};