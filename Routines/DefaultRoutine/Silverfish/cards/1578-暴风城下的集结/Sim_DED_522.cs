using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_522 : SimTemplate //* 厨师曲奇 Cookie the Cook
    {
        //吸血，亡语：装备一把2/3并具有吸血的搅汤棒。
        //Lifesteal Deathrattle: Equip a 2/3 Stirring Rod with Lifesteal.
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DED_522t);

        public override void onDeathrattle(Playfield p, Minion own)
        {
            p.equipWeapon(w, own.own);
        }
    }
}
