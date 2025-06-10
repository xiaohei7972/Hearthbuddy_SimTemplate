using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
  class Sim_GIL_548 : SimTemplate //* 怨灵之书 Book of Specters
//Draw 3 cards. Discard any spells drawn.
//抽三张牌。弃掉抽到的所有法术牌。 
  {



    public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
    {
      p.drawACard(CardDB.cardNameEN.unknown, ownplay);
      p.drawACard(CardDB.cardNameEN.unknown, ownplay);
      p.drawACard(CardDB.cardNameEN.unknown, ownplay);

      bool alunethInHand = false;
      if (p.ownWeapon.Durability >= 1)
      {
        if (ownplay) p.evaluatePenality += 40;
      }

      else
      {
        foreach (Handmanager.Handcard hc in p.owncards)
        {
          if (hc.card.nameEN == CardDB.cardNameEN.aluneth)
          {
            alunethInHand = true;
            break;
          }
        }

        if (alunethInHand && p.ownMaxMana > 5 && ownplay)
        {
          p.evaluatePenality += 20;
        }
      }
    }
  }
}