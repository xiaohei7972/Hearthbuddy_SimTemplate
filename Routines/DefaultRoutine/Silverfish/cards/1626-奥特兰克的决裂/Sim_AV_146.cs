using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AV_146 : SimTemplate //* 无法撼动之物 theimmovableobject
    {
        //不会失去耐久度。你的英雄受到的伤害减半，向上取整。
        static readonly CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_146);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
            //(ownplay ? p.ownHero : p.enemyHero).enchs.Add(CardDB.cardIDEnum.AV_146e);
        }

    }
}
