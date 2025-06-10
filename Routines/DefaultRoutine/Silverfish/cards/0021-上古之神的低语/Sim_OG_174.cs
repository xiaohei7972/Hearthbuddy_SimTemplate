using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_174 : SimTemplate //* 无面蹒跚者 Faceless Shambler
//<b>Taunt</b><b>Battlecry:</b> Copy a friendly minion's Attack and Health.
//<b>嘲讽</b>，<b>战吼：</b>复制一个友方随从的攻击力和生命值。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null)
			{
				own.Hp = target.Hp;
				own.Angr = target.Angr;
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}