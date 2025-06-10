using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//Induce Insanity
	//诱引狂乱
	//Force each enemy minion to attack a random enemy minion.
	//迫使每个敌方随从分别随机攻击一个敌方随从。
	class Sim_YOG_516t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.RandomEnemyMinionsAttackEachOther(); // 让每个敌方随从随机攻击一个敌方随从
        }
    }
}
