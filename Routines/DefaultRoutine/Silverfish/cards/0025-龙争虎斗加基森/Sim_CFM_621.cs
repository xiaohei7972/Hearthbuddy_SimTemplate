using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621 : SimTemplate //* 卡扎库斯 Kazakus
//[x]<b>Battlecry:</b> If your deckhas no duplicates,_create a custom spell.
//<b>战吼：</b>如果你的牌库里没有相同的牌，则为你创建一个自定义法术。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own && p.prozis.noDuplicates) p.drawACard(CardDB.cardNameEN.thecoin, m.own, true);
        }
    }
}