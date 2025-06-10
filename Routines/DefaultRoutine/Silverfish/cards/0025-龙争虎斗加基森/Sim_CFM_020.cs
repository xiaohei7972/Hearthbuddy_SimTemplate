using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_020 : SimTemplate //* 缚链者拉兹 Raza the Chained
//[x]  <b>Battlecry:</b> If your deck has  no duplicates, your Hero Power costs (0) this game.
//<b>战吼：</b>在本局对战中，如果你的牌库里没有相同的牌，则你的英雄技能的法力值消耗为（0）点。 
	{
		
				
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.prozis.noDuplicates) p.ownHeroAblility.manacost = 0;
        }
	}
}