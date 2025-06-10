using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_713 : SimTemplate //* 青玉绽放 Jade Blossom
//Summon a{1} {0} <b>Jade Golem</b>. Gain an empty Mana Crystal.@Summon a <b>Jade Golem</b>. Gain an empty Mana Crystal.
//召唤一个{0}的<b>青玉魔像</b>，获得一个空的法力水晶。@召唤一个<b>青玉魔像</b>，获得一个空的法力水晶。 
	{
		
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(p.getNextJadeGolem(ownplay), place, ownplay, false);

            if (ownplay) p.ownMaxMana = Math.Min(10, p.ownMaxMana + 1);
            else p.enemyMaxMana = Math.Min(10, p.enemyMaxMana + 1);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT),
            };
        }
    }
}