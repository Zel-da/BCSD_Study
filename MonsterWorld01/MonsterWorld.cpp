#include "MonsterWorld.h"
#include <time.h>

void main()
{
	srand((unsigned int)time(NULL));
	int w = 16, h = 8;
	system("mode con: cols=34 lines=30"); // 콘솔창 크기 조절
	MonsterWorld game(w, h);
	//Monster m("몬스터", "※", rand() % w, rand() % h);
	//game.add(m)
	game.add(new Monster("몬스터", "몬", rand() % w, rand() % h)); // 호출하고 사라진다.
	game.add(new Monster("도깨비", "도", rand() % w, rand() % h));
	game.add(new Monster("별그대", "별", rand() % w, rand() % h));
	game.add(new Monster("고스트", "고", rand() % w, rand() % h));
	game.add(new Monster("나이트", "나", rand() % w, rand() % h));
	game.play(500, 10);
	printf("------게임 종료-------------------\n");
}