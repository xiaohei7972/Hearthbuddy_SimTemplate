using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_508 : SimTemplate //* 夜行蝙蝠 Duskbat
//<b>Battlecry:</b> If your hero took damage this turn, summon two 1/1 Bats.
//<b>战吼：</b>如果你的英雄在本回合受到过伤害，召唤两只1/1的蝙蝠。 
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_508t);


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.ownHero.anzGotDmg > 0 )
			{
                p.callKid(kid, own.zonepos, own.own);
                p.callKid(kid, own.zonepos, own.own);
			}
		}


	}
}