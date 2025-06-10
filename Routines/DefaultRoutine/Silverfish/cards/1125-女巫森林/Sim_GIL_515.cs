using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_515 : SimTemplate //* 捕鼠人 Ratcatcher
//<b>Rush</b><b>Battlecry:</b> Destroy a friendly minion and gain its Attack and Health.
//<b>突袭，战吼：</b>消灭一个友方随从，并获得其攻击力和生命值。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;

            int angr = 0;
            int hp = 0;
            foreach (Minion m in temp)
            {
                if (m.zonepos == own.zonepos - 1 || m.zonepos == own.zonepos + 1)
                {
                    angr += m.Angr;
                    hp += m.Hp;
                    p.minionGetDestroyed(m);
                }
            }
            p.minionGetBuffed(own, angr, hp);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}