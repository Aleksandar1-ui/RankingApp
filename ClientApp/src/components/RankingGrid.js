const RankingGrid = ({ items, imgArr }) => {
    const rankingGrid = [];
    const cellCollectionTop = [];
    const cellCollectionMiddle = [];
    const cellCollectionBottom = [];
    const cellCollectionWorst = [];

    function pushCellMarkupToArr(cellCollection, rankNum, rowLabel) {
        if (rankNum > 0) {
            var item = items.find(o => o.ranking === rankNum);
            cellCollection.push(<div id={`rank-${rankNum}`} className="rank-cell"></div>);
        }
        else {
            cellCollection.push(<div className="row-label">
                <h4>{rowLabel}</h4>
            </div>);
        }
    }
    function createCellsForRow(num) {
        var rankNum = 0;
        var currentCollection = [];
        var l = "";
        const numCells = 5;
        for (var i = 1; i <= numCells; i++) {
            rankNum = (i === 1) ? 0 : (numCells * (num - 1)) + i - num;
            if (num === 1) {
                currentCollection = cellCollectionTop;
                l = "Top Tier";
            }
            else if (num === 2) {
                currentCollection = cellCollectionMiddle;
                l = "Middle Tier";
            }
            else if (num === 3) {
                currentCollection = cellCollectionBottom;
                l = "Bottom Tier";
            }
            else if (num === 4) {
                currentCollection = cellCollectionWorst;
                l = "Worst Tier";
            }
            pushCellMarkupToArr(currentCollection, rankNum, l);
        }
    }
    function createCellsForRows() {
        var maxRows = 4;
        for (var i = 1; i <= maxRows; i++) {
            createCellsForRow(i);
        }
    }
    function createRowsForGrid() {
        rankingGrid.push(<div className="rank-row top-tier">{cellCollectionTop}</div>);
        rankingGrid.push(<div className="rank-row middle-tier">{cellCollectionMiddle}</div>);
        rankingGrid.push(<div className="rank-row bottom-tier">{cellCollectionBottom}</div>);
        rankingGrid.push(<div className="rank-row worst-tier">{cellCollectionWorst}</div>);
        return rankingGrid;
    }
    function createRankingGrid() {
        createCellsForRows();
        return createRowsForGrid();
    }
    return (
        <div className="rankings">
            {createRankingGrid()}
        </div>
        )
}
export default RankingGrid;