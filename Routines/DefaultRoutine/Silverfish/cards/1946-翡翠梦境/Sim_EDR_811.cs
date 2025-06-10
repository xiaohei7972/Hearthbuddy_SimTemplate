using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_EDR_811 : SimTemplate //* 暴行祭礼 Rite of Atrocity
    {
        //<b>Discover</b> an Undead. Spend 2 <b>Corpses</b> to give it a <b>Dark Gift</b>.
        //<b>发现</b>一张亡灵牌。消耗2份<b>残骸</b>，使其获得<b>黑暗之赐</b>。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (p.ownHeroHasDirectLethal()) p.callKid(CardDB.Instance.getCardData(CardDB.cardNameEN.icehowl), pos, ownplay, false);
        }
    }
}
