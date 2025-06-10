using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_912: SimTemplate //* 夺尸者 Corpsetaker
//[x]<b>Battlecry:</b> Gain <b>Taunt</b> if yourdeck has a <b>Taunt</b> minion.Repeat for <b>Divine Shield</b>,<b>Lifesteal</b>, <b>Windfury</b>.
//<b>战吼：</b>如果你的牌库里包含具有<b>嘲讽</b>的随从牌，则获得<b>嘲讽</b>。依此法检定是否可获得<b>圣盾</b>、<b>吸血</b>和<b>风怒</b>。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.prozis.numDeckCardsByTag(GAME_TAGs.TAUNT) > 0)
                {
                    own.taunt = true;
                    p.anzOwnTaunt++;
                }
                if (p.prozis.numDeckCardsByTag(GAME_TAGs.DIVINE_SHIELD) > 0) own.divineshild = true;
                if (p.prozis.numDeckCardsByTag(GAME_TAGs.LIFESTEAL) > 0) own.lifesteal = true;
                if (p.prozis.numDeckCardsByTag(GAME_TAGs.WINDFURY) > 0) own.windfury = true;
            }
        }
    }
}