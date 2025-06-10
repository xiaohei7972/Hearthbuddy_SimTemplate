using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_240 : SimTemplate //* 救赎者洛萨克森 Lothraxion the Redeemed
	{
		//[x]<b>Battlecry:</b> For the rest of thegame, after you summona Silver Hand Recruit,give it <b>Divine Shield</b>.
		//<b>战吼：</b>在本局对战的剩余时间内，在你召唤一个白银之手新兵后，使其获得<b>圣盾</b>。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if(own.own) p.LothraxionsPower=true;
		}
		
	}
}
