using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_850: SimTemplate //* 暗影之刃 Shadowblade
//<b>Battlecry:</b> Your hero is <b>Immune</b> this turn.
//<b>战吼：</b>在本回合中，你的英雄获得<b>免疫</b>。 
    {
        

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_850);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);

            if (ownplay) p.ownHero.immune = true;
            else p.enemyHero.immune = true;
        }
    }
}