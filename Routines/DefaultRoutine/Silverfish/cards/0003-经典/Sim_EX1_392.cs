using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_392 : SimTemplate //* 战斗怒火 Battle Rage
	{
		//Draw a card for each damaged friendly character.
		//每有一个受伤的友方角色，便抽一张牌。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay)? p.ownMinions : p.enemyMinions;
            foreach (Minion mnn in temp )
            {
                if (mnn.wounded)
                {
                    p.drawACard(CardDB.cardIDEnum.None, ownplay);
                }
            }
            if (ownplay && p.ownHero.Hp < 30) p.drawACard(CardDB.cardIDEnum.None, true);
            if (!ownplay && p.enemyHero.Hp < 30) p.drawACard(CardDB.cardIDEnum.None, false);

		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}