using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_900 : SimTemplate //哈尔拉兹，山猫之神
	{

//    战吼：将1/1并具有突袭的山猫置入你的手牌，直到你的手牌数量达到上限

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.lynx, own.own);
			p.drawACard(CardDB.cardNameEN.lynx, own.own);
			p.drawACard(CardDB.cardNameEN.lynx, own.own);
			p.drawACard(CardDB.cardNameEN.lynx, own.own);
			p.drawACard(CardDB.cardNameEN.lynx, own.own);
			p.drawACard(CardDB.cardNameEN.lynx, own.own);
			p.drawACard(CardDB.cardNameEN.lynx, own.own);
			p.drawACard(CardDB.cardNameEN.lynx, own.own);
			p.drawACard(CardDB.cardNameEN.lynx, own.own);
			p.drawACard(CardDB.cardNameEN.lynx, own.own);
		}


	}
}