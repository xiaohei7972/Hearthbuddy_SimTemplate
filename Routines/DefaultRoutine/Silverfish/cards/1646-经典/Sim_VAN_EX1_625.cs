using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_VAN_EX1_625 : SimTemplate //* 暗影形态 Shadowform
//Your Hero Power becomes 'Deal 2 damage'. If already in Shadowform: 3 damage.
//你的英雄技能变为“造成2点伤害”，如果已经处于暗影形态下：改为“造成3点伤害”。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            CardDB.cardIDEnum newHeroPower = CardDB.cardIDEnum.EX1_625t; 
            if ((ownplay ? p.ownHeroAblility.card.cardIDenum : p.enemyHeroAblility.card.cardIDenum) == CardDB.cardIDEnum.EX1_625t) newHeroPower = CardDB.cardIDEnum.EX1_625t2; 
            p.setNewHeroPower(newHeroPower, ownplay);
        }
    }
}