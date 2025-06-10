using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_770 : SimTemplate //* 欧米茄毁灭者
	{
		//战吼:如果你有十个法力水晶，对一个随从造成10点伤害.
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own) 
			{
				if (p.ownMaxMana ==10)
				{
					if (target != null)
					{
						int dmg = 10;
						p.minionGetDamageOrHeal(target, dmg);
					}
				}
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}