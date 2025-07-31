using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：8 攻击力：4 生命值：10
	//Nightmare Demon
	//梦魇恶魔
	//<b>Battlecry:</b> Destroy all enemy minions.
	//<b>战吼：</b>消灭所有敌方随从。
	class Sim_Story_08_NightmareDemon : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> minions = ownplay ? p.enemyMinions : p.ownMinions;
            foreach (Minion minion in minions)
            {
                p.minionGetDestroyed(minion);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS,1),
            };
        }
		
	}
}
