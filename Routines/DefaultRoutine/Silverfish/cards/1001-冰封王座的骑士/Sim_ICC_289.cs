using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_289: SimTemplate //* 莫拉比 Moorabi
//Whenever another minion is <b>Frozen</b>, add a copy of it to your hand.
//每当有其他随从被<b>冻结</b>，将一张被<b>冻结</b>随从的复制置入你的手牌。 
    {
        

        public override void onAuraStarts(Playfield p, Minion own)
        {
            p.anzMoorabi++;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            p.anzMoorabi--;
        }
    }
}