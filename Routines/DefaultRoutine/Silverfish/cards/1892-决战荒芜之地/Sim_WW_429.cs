using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：5 攻击力：6 生命值：5
	//Mes'Adune the Fractured
	//碎裂巨岩迈沙顿
	//<b>Battlecry:</b> Draw an Elemental. Split itinto two halves.
	//<b>战吼：</b>抽一张元素牌，将其拆成两半。
	class Sim_WW_429 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own);
            p.drawACard(CardDB.cardIDEnum.None, own.own);
		}
		
	}
}
