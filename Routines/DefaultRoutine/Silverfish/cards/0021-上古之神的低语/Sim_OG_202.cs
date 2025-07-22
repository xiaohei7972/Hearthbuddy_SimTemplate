using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_202 : SimTemplate //* 泥潭守护者 Mire Keeper
//[x]<b>Choose One -</b> Summon a2/2 Slime; or Gain anempty Mana Crystal.
//<b>抉择：</b>召唤一个2/2的泥浆怪；或者获得一个空的法力水晶。 
    {
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NAX11_03);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (choice == 2 || (p.ownFandralStaghelm > 0 && own.own))
            {
                if (own.own)
                {
                    if (p.ownMaxMana > 8) p.evaluatePenality += 15;
                    p.ownMaxMana = Math.Min(10, p.ownMaxMana + 1);
                }
                else p.enemyMaxMana = Math.Min(10, p.enemyMaxMana + 1);
            }
            
            if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.callKid(kid, own.zonepos, own.own);
            }
        }
    }
}