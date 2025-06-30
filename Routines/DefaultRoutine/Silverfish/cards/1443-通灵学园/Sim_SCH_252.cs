using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_SCH_252 : SimTemplate //* 切髓之刃 Marrowslicer
    {
        //<b>Battlecry:</b> Shuffle 2 Soul Fragments into your deck.
        //<b>战吼：</b>将两张灵魂残片洗入你的牌库。
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_672);
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_307t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.AddToDeck(card);
            p.AddToDeck(card);
        }


    }
}
