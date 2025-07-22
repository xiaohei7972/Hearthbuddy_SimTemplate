using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_006 : SimTemplate //* 邪鳍审判者 Vilefin Inquisitor
//<b>Battlecry:</b> Your Hero Power becomes 'Summon a   1/1 Murloc.'
//<b>战吼：</b>你的英雄技能变为“召唤一个1/1的鱼人”。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.OG_006b, own.own); 
		}
	}
}