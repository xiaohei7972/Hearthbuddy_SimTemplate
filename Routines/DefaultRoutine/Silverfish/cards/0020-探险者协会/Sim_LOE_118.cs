using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    //* 诅咒之刃 Cursed Blade
    //Double all damage dealt to your hero.
    //你的英雄受到的所有伤害效果翻倍。 
    class Sim_LOE_118 : SimTemplate
    {
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOE_118);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

    }
}