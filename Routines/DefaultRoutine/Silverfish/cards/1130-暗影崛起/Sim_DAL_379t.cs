using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_379t : SimTemplate //* 索利达尔，群星之怒 Thori'dal, the Stars' Fury
//After your hero attacks, gain <b>Spell Damage +2</b> this turn.
//在你的英雄攻击后，在本回合中获得<b>法术伤害+2</b>。 
	{


        CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_379t);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(wcard, ownplay);
        }
	}
}