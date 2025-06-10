using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_703 : SimTemplate //* 灵魂学家玛丽希亚 Soulciologist Malicia
	{
        //<b>Battlecry:</b> For each Soul Fragment in your deck, summon a 3/3 Soul with <b>Rush</b>.@ <i>(@)</i>
        //<b>战吼：</b>你的牌库中每有一张灵魂残片，召唤一个3/3并具有<b>突袭</b>的灵魂。@<i>（@）</i>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_703t);
            if (own.own)
            {
                for (int i = 0; i < p.AnzSoulFragments; i++)
                {
                    int pos = (i % 2 == 0) ? own.zonepos : own.zonepos - 1;
                    if (p.ownMinions.Count < 7)
                        p.callKid(kid, pos, true);
                    else return;
                }
            }
        }
    }
}
