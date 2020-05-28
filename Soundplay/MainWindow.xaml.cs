using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;


namespace ChordProgressionFinder
{

    public partial class ChordProgressionFinder
    {
        public ChordProgressionFinder()
        {
            InitializeComponent();
            this.MouseLeftButtonDown += (sender, e) => this.DragMove();

        }
        private void C(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ceg");
        }
        private void Cm(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ce-g");
        }
        private void Cdim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ce-g-");
        }
        private void Caug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ceg+");
        }
        private void Csus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5cfg");
        }
        private void Csus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5cdg");
        }
        private void C7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5cega+");
        }
        private void Cm7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ce-ga+");
        }
        private void CM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5cegb");
        }
        private void C7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5cfga+");
        }
        private void Cadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5cdeg");
        }
        private void CmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5cd+gb");
        }
        private void Cdim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ce-g-a");
        }
        private void C69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5cdega");
        }
        private void C6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5cega");
        }
        private void Cm6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ce-ga");
        }
        private void Db(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d-fa-");
        }
        private void Dbm(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d-ea-");
        }
        private void Dbdim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d-eg");
        }
        private void Dbaug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d-fa");
        }
        private void Dbsus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+f+g+");
        }
        private void Dbsus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+d+g+");
        }
        private void Db7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+fg+b");
        }
        private void Dbm7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+eg+b");
        }
        private void DbM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+fg+o6c");
        }
        private void Db7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+f+g+b");
        }
        private void Dbadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+d+fg+");
        }
        private void DbmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+eg+o6c");
        }
        private void Dbdim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+ega+");
        }
        private void Db69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+d+fg+a+");
        }
        private void Db6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+fg+a+");
        }
        private void Dbm6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+eg+a+");
        }
        private void D(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5df+a");
        }
        private void Dm(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5dfa");
        }
        private void Ddim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5dfg+");
        }
        private void Daug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5df+a+");
        }
        private void Dsus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5dga");
        }
        private void Dsus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5dea");
        }
        private void D7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5df+ao6c");
        }
        private void Dm7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5dfao6c");
        }
        private void DM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5df+ao6c+");
        }
        private void D7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5dgao6c");
        }
        private void Dadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5def+a");
        }
        private void DmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5dfao6c+");
        }
        private void Ddim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5dfg+b");
        }
        private void D69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5def+ab");
        }
        private void D6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5df+ab");
        }
        private void Dm6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5dfab");
        }
        private void Eb(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+ga+");
        }
        private void Ebm(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+f+a+");
        }
        private void Ebdim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+f+a");
        }
        private void Ebaug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+gb");
        }
        private void Ebsus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+g+a+");
        }
        private void Ebsus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+fa+");
        }
        private void Eb7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+ga+o6c+");
        }
        private void Ebm7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+f+a+o6c+");
        }
        private void EbM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+ga+o6d");
        }
        private void Eb7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+g+a+o6c+");
        }
        private void Ebadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+fga+");
        }
        private void EbmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+f+a+o6d");
        }
        private void Ebdim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+f+ao6c");
        }
        private void Eb69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+fga+o6c");
        }
        private void Eb6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+ga+o6c");
        }
        private void Ebm6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+f+a+o6c");
        }
        private void E(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5eg+b");
        }
        private void Em(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5egb");
        }
        private void Edim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ega+");
        }
        private void Eaug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5eg+o6c");
        }
        private void Esus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5eab");
        }
        private void Esus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ef+b");
        }
        private void E7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5eg+bo6d");
        }
        private void Em7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5egbo6d");
        }
        private void EM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5eg+bo6d+");
        }
        private void E7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5eabo6d");
        }
        private void Eadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ef+g+b");
        }
        private void EmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5egbo6d+");
        }
        private void Edim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ega+o6c+");
        }
        private void E69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ef+g+bo6c+");
        }
        private void E6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5eg+bo6c+");
        }
        private void Em6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5egbo6c+");
        }
        private void F(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fao6c");
        }
        private void Fm(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fg+o6c");
        }
        private void Fdim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fg+b");
        }
        private void Faug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fao6c+");
        }
        private void Fsus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fa+o6c");
        }
        private void Fsus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fgo6c");
        }
        private void F7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fao6co6d+");
        }
        private void Fm7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fg+o6co6d+");
        }
        private void FM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fao6co6e");
        }
        private void F7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fa+o6co6d+");
        }
        private void Fadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fgao6c");
        }
        private void FmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fg+o6co6e");
        }
        private void Fdim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fg+bo6d");
        }
        private void F69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fgao6co6d");
        }
        private void F6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fao6co6d");
        }
        private void Fm6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5fg+o6co6d");
        }
        private void Gb(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+a+o6c+");
        }
        private void Gbm(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+ao6c+");
        }
        private void Gbdim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+ao6c");
        }
        private void Gbaug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+a+o6d");
        }
        private void Gbsus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+bo6c+");
        }
        private void Gbsus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+g+o6c+");
        }
        private void Gb7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+a+o6c+o6e");
        }
        private void Gbm7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+ao6c+o6e");
        }
        private void GbM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+a+o6c+o6f");
        }
        private void Gb7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+bo6c+e");
        }
        private void Gbadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+g+a+o6c+");
        }
        private void GbmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+ao6c+o6f");
        }
        private void Gbdim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+ao6co6d+");
        }
        private void Gb69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+g+a+o6c+o6d+");
        }
        private void Gb6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+a+o6c+o6d+");
        }
        private void Gbm6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+ao6c+o6d+");
        }
        private void G(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5gbo6d");
        }
        private void Gm(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ga+o6d");
        }
        private void Gdim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ga+o6c+");
        }
        private void Gaug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5gbo6d+");
        }
        private void Gsus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5go6co6d");
        }
        private void Gsus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5gao6d");
        }
        private void G7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5gbo6do6f");
        }
        private void Gm7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ga+o6do6f");
        }
        private void GM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5gbo6do6f+");
        }
        private void G7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5go6co6do6f");
        }
        private void Gadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5gabo6d");
        }
        private void GmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ga+o6do6f+");
        }
        private void Gdim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ga+o6c+o6e");
        }
        private void G69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5gabo6do6e");
        }
        private void G6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5gbo6do6e");
        }
        private void Gm6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ga+o6do6e");
        }
        private void Ab(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+o6co6d+");
        }
        private void Abm(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+bo6d+");
        }
        private void Abdim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+bo6d");
        }
        private void Abaug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+o6co6e");
        }
        private void Absus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+o6c+o6d+");
        }
        private void Absus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+a+o6d+");
        }
        private void Ab7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+o6co6d+o6f+");
        }
        private void Abm7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+bo6d+o6f+");
        }
        private void AbM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+o6co6d+o6g");
        }
        private void Ab7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+o6c+o6d+o6f+");
        }
        private void Abadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+a+o6co6d+");
        }
        private void AbmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+bo6d+o6g");
        }
        private void Abdim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+bo6do6f");
        }
        private void Ab69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+a+o6co6d+o6f");
        }
        private void Ab6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+o6co6d+o6f");
        }
        private void Abm6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+bo6d+o6f");
        }
        private void A(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6c+e");
        }
        private void Am(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6co6e");
        }
        private void Adim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6co6d+");
        }
        private void Aaug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6c+o6f");
        }
        private void Asus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6do6e");
        }
        private void Asus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5abo6e");
        }
        private void A7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6c+o6eo6g");
        }
        private void Am7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6co6eo6g");
        }
        private void AM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6c+o6eo6g+");
        }
        private void A7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6do6eo6g");
        }
        private void Aadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5abo6c+o6e");
        }
        private void AmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6co6eo6g+");
        }
        private void Adim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6co6d+o6f+");
        }
        private void A69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5abo6c+o6eo6f+");
        }
        private void A6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6c+o6eo6f+");
        }
        private void Am6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5ao6co6eo6f+");
        }
        private void Bb(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6do6f");
        }
        private void Bbm(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6c+o6f");
        }
        private void Bbdim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6c+o6e");
        }
        private void Bbaug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6do6f+");
        }
        private void Bbsus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6d+o6f");
        }
        private void Bbsus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6co6f");
        }
        private void Bb7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6do6fo6g+");
        }
        private void Bbm7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6c+o6fo6g+");
        }
        private void BbM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6do6fo6a");
        }
        private void Bb7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6d+o6fo6g+");
        }
        private void Bbadd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6co6do6f");
        }
        private void BbmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6c+o6fo6a");
        }
        private void Bbdim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6c+o6eo6g");
        }
        private void Bb69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6co6do6fo6g");
        }
        private void Bb6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6do6fo6g");
        }
        private void Bbm6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+o6c+o6fo6g");
        }
        private void B(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6d+o6f+");
        }
        private void Bm(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6do6f+");
        }
        private void Bdim(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6do6f");
        }
        private void Baug(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6d+o6g");
        }
        private void Bsus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6eo6f+");
        }
        private void Bsus2(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6c+o6f+");
        }
        private void B7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6d+o6f+o6a");
        }
        private void Bm7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6do6f+o6a");
        }
        private void BM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6d+f+a+");
        }
        private void B7sus4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6eo6f+o6a");
        }
        private void Badd9(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6c+d+f+");
        }
        private void BmM7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6df+a+");
        }
        private void Bdim7(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6do6fo6g+");
        }
        private void B69(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6c+o6d+o6f+o6g+");
        }
        private void B6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6d+o6f+o6g+");
        }
        private void Bm6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5bo6do6f+o6g+");
        }
        private void CO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4c");
        }
        private void DbO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4c+");
        }
        private void DO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4d");
        }
        private void EbO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4d+");
        }
        private void EO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4e");
        }
        private void FO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4f");
        }
        private void GbO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4f+");
        }
        private void GO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4g");
        }
        private void AbO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4g+");
        }
        private void AO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4a");
        }
        private void BbO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4a+");
        }
        private void BO4(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O4b");
        }
        private void CO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c");
        }
        private void DbO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5c+");
        }
        private void DO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d");
        }
        private void EbO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5d+");
        }
        private void EO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5e");
        }
        private void FO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f");
        }
        private void GbO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5f+");
        }
        private void GO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g");
        }
        private void AbO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5g+");
        }
        private void AO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a");
        }
        private void BbO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5a+");
        }
        private void BO5(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O5b");
        }
        private void CO6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O6c");
        }
        private void DbO6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O6c+");
        }
        private void DO6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O6d");
        }
        private void EbO6(object sender, RoutedEventArgs e)
        {
            Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O6d+");
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Z)
            {
                Microsoft.SmallBasic.Library.Sound.PlayMusic("L99O6d+");
            }
        }
        private void TopMost(object sender, RoutedEventArgs e)
        {
            Topmost=true;
        }
        private void UnTop(object sender, RoutedEventArgs e)
        {
            Topmost = false;
        }
    }
    }
