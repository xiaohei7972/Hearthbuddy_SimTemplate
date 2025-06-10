using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_017 : SimTemplate //* 奥达曼守护者 Keeper of Uldaman
//<b>Battlecry:</b> Set a minion's Attack and Health to 3.
//<b>战吼：</b>将一个随从的攻击力和生命值变为3。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target != null)
			{
				p.minionSetAngrToX(target, 3);
				p.minionSetLifetoX(target, 3);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}