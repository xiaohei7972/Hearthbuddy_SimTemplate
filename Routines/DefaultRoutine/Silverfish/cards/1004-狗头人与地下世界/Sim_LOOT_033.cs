using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_033 : SimTemplate //* 洞穴探宝者 Cavern Shinyfinder
//<b>Battlecry:</b> Draw a weapon from your deck.
//<b>战吼：</b>从你的牌库中抽一张武器牌。
	{
		

        /*public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.kingsbane, own.own);这是合理的sim，但是目前剑鱼横行，暂时修改sim固定为抽剑鱼
        }*/
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.swordfish, own.own);
        }
}
}