#include "MonsterWorld.h"
#include <time.h>

void main()
{
	srand((unsigned int)time(NULL));
	int w = 16, h = 8;
	system("mode con: cols=34 lines=30"); // �ܼ�â ũ�� ����
	MonsterWorld game(w, h);
	//Monster m("����", "��", rand() % w, rand() % h);
	//game.add(m)
	game.add(new Monster("����", "��", rand() % w, rand() % h)); // ȣ���ϰ� �������.
	game.add(new Monster("������", "��", rand() % w, rand() % h));
	game.add(new Monster("���״�", "��", rand() % w, rand() % h));
	game.add(new Monster("��Ʈ", "��", rand() % w, rand() % h));
	game.add(new Monster("����Ʈ", "��", rand() % w, rand() % h));
	game.play(500, 10);
	printf("------���� ����-------------------\n");
}