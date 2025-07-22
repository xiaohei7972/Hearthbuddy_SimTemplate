using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_717 : SimTemplate //* 青玉之爪 Jade Claws
//<b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>.<b><b>Overload</b>:</b> (1)@<b>Battlecry:</b> Summon a <b>Jade Golem</b>.<b><b>Overload</b>:</b> (1)
//<b>战吼：</b>召唤一个{0}的<b>青玉魔像</b>。<b>过载：</b>（1）@<b>战吼：</b>召唤一个<b>青玉魔像</b>。<b>过载：</b>（1） 
	{
		

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CFM_717);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);

            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(p.getNextJadeGolem(ownplay), place, ownplay);
        }
    }
}