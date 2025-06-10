using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：0
	//Pacified
	//平静
	//Set the Attack and Health of all enemy minions to 2.
	//将所有敌方随从的攻击力和生命值变为2。
	class Sim_TTN_858t3 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.enemyMinions.ForEach(m =>
            {
                m.Angr = 2;
                m.Hp = 2;
            });
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS)  // 需要至少有一个敌方随从
            };
        }
    }
}
