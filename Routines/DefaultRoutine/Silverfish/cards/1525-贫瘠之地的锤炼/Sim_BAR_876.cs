using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_876 : SimTemplate //* 北卫军指挥官 Northwatch Commander
	{
		//<b>Battlecry:</b> If you control a <b>Secret</b>, draw a minion.
		//<b>战吼：</b>如果你控制一个<b>奥秘</b>，抽一张随从牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if(p.ownSecretsIDList.Count>=1)
            {
				p.drawACard(CardDB.cardIDEnum.None, own.own);	
				p.evaluatePenality -= 10;
            } 	
        }
	}
}
