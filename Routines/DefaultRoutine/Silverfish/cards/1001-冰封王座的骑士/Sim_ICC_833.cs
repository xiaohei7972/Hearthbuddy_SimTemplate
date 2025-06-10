using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_833: SimTemplate //* 冰霜女巫吉安娜 Frost Lich Jaina
//[x]<b>Battlecry:</b> Summon a3/6 Water Elemental.Your Elementals have<b>Lifesteal</b> this game.
//<b>战吼：</b>召唤一个3/6的水元素。在本局对战中，你的所有元素具有<b>吸血</b>。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_833t); 

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.ICC_833h, ownplay); 
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
            
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay);
        }
    }
}