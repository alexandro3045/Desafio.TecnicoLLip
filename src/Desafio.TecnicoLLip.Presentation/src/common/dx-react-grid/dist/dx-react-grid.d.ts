// Dependencies for this module:
//   ../../../../react
//   ../../../../@devexpress/dx-core

import * as React from 'react';
import { GetMessageFn } from '@devexpress/dx-core';
import { PureComputed } from '@devexpress/dx-core';

/***
  * The Grid is a root container component designed to process and display data specified via
  * the `rows` property. You can configure columns using the `columns` property. The Grid's
  * functionality  is implemented in several plugins specified as child components.
  * See the plugins concept for details.
  * */
export const Grid: React.ComponentType<GridProps>;

/***
  * The ColumnChooser plugin allows a user to toggle grid columns' visibility at runtime.
  * The column chooser lists columns with checkboxes that control a corresponding
  * column's visibility.
  * */
export const ColumnChooser: React.ComponentType<ColumnChooserProps>;

/** A plugin that manages the filtering state. */
export const FilteringState: React.ComponentType<FilteringStateProps>;

export const IntegratedFiltering: React.ComponentType<IntegratedFilteringProps> & {
  /***
    * The built-in filter predicate.
    * The `filter` parameter accepts an object containing the 'value' field.
    **/
  defaultPredicate: DefaultPredicateFn;
};

/***
  * A plugin that manages grid rows' editing state. It arranges grid rows
  * by different lists depending on a row's state.
  * */
export const EditingState: React.ComponentType<EditingStateProps>;

/***
  * A plugin that manages the paging state. It controls the total page count depending on the
  * total row count and the specified page size, controls the currently selected page number
  * and changes it in response to the corresponding actions.
  * */
export const PagingState: React.ComponentType<PagingStateProps>;

/***
  * A plugin that performs built-in data paging. It also changes the current page if the provided
  * one cannot be applied due to fewer available pages.
  * */
export const IntegratedPaging: React.ComponentType<IntegratedPagingProps>;

/** A plugin that allows implementing a custom totalCount calculation logic. */
export const CustomPaging: React.ComponentType<CustomPagingProps>;

/***
  * A plugin that manages the grouping state. It lists columns used for grouping and stores
  * information about expanded/collapsed groups.
  * */
export const GroupingState: React.ComponentType<GroupingStateProps>;

/** A plugin that performs built-in grouping and group expanding/collapsing. */
export const IntegratedGrouping: React.ComponentType<IntegratedGroupingProps>;

/** A plugin that converts custom formatted grouped data to a supported format and performs local group expanding/collapsing. */
export const CustomGrouping: React.ComponentType<CustomGroupingProps>;

/** A plugin that manages the selection state. */
export const SelectionState: React.ComponentType<SelectionStateProps>;

/** A plugin that performs built-in selection. */
export const IntegratedSelection: React.ComponentType<IntegratedSelectionProps>;

/** A plugin that manages the sorting state. It controls the list of columns that participate in sorting. */
export const SortingState: React.ComponentType<SortingStateProps>;

/** A plugin that performs built-in data sorting. */
export const IntegratedSorting: React.ComponentType<IntegratedSortingProps>;

/** A plugin that implements the drag-and-drop functionality and visualizes columns that are being dragged. */
export const DragDropProvider: React.ComponentType<DragDropProviderProps>;

/** A plugin that manages the displayed columns' order. */
export const TableColumnReordering: React.ComponentType<TableColumnReorderingProps>;

/***
  * A plugin that renders Grid data as a table. This plugin enables you to customize
  * table rows and columns, and contains the Table Row and Table Cell components
  * that can be extended by other plugins
  * */
export const Table: React.ComponentType<TableProps> & {
  /** The data column type's indentifier. */
  COLUMN_TYPE: symbol;
  /** The data row type's indentifier. */
  ROW_TYPE: symbol;
  /** The nodata row type's indentifier. */
  NODATA_ROW_TYPE: symbol;
};

/***
  * A plugin that visualizes table rows' selection state by rendering selection checkboxes
  * and highlighting the selected rows.
  * */
export const TableSelection: React.ComponentType<TableSelectionProps> & {
  /** The selection column type's indentifier. */
  COLUMN_TYPE: symbol;
};

/** A plugin that manages the expanded state for table row details. */
export const RowDetailState: React.ComponentType<RowDetailStateProps>;

/** A plugin that renders detail rows. */
export const TableRowDetail: React.ComponentType<TableRowDetailProps> & {
  /** The detail column type's identifier. */
  COLUMN_TYPE: symbol;
  /** The detail row type's indentifier. */
  ROW_TYPE: symbol;
};

/** A plugin that renders group rows and enables them to expand and collapse. */
export const TableGroupRow: React.ComponentType<TableGroupRowProps> & {
  /** The group column type's identifier. */
  COLUMN_TYPE: symbol;
  /** The group row type's identifier. */
  ROW_TYPE: symbol;
};

/***
  * A plugin that renders the table's header row. The Column's `title` field specifies the
  * column's title in the header row.The plugin also allows you to manage a column's sorting
  * and grouping state and initiate column dragging.
  * */
export const TableHeaderRow: React.ComponentType<TableHeaderRowProps> & {
  /** The header row type's identifier. */
  ROW_TYPE: symbol;
};

/** A plugin that renders the banded cells. */
export const TableBandHeader: React.ComponentType<TableBandHeaderProps> & {
  /** The band row type's identifier. */
  ROW_TYPE: symbol;
};

/** A plugin that renders a filter row. */
export const TableFilterRow: React.ComponentType<TableFilterRowProps> & {
  /** The filter row type's identifier. */
  ROW_TYPE: symbol;
};

/** A plugin that renders a row being edited. */
export const TableEditRow: React.ComponentType<TableEditRowProps> & {
  /** The added row type's identifier. */
  ADDED_ROW_TYPE: symbol;
  /** The edit row type's identifier. */
  EDIT_ROW_TYPE: symbol;
};

/***
  * A plugin that renders a command column. This column contains controls used for row editing,
  * creating, or deleting and committing/canceling changes.
  * */
export const TableEditColumn: React.ComponentType<TableEditColumnProps> & {
  /** The edit column type's identifier. */
  COLUMN_TYPE: symbol;
};

/** A plugin that manages table column widths. */
export const TableColumnResizing: React.ComponentType<TableColumnResizingProps>;

/** A plugin that renders the paging panel used for navigation through data pages. */
export const PagingPanel: React.ComponentType<PagingPanelProps>;

/***
  * A plugin that renders the Grouping Panel in the Grid's header. This panel displays grouped
  * columns and allows a user to modify grouping options.Optionally, the plugin allows an end-user
  * to change grouped columns' sorting order and render sorting indicators.
  * */
export const GroupingPanel: React.ComponentType<GroupingPanelProps>;

/** A plugin that allows you to customize formatting options and editors depending on the data type. */
export const DataTypeProvider: React.ComponentType<DataTypeProviderProps>;

/** A plugin that manages Grid columns' visibility. */
export const TableColumnVisibility: React.ComponentType<TableColumnVisibilityProps>;

/** A plugin that renders the Grid toolbar. */
export const Toolbar: React.ComponentType<ToolbarProps>;

/** A plugin that manages the expanded state for tree rows. */
export const TreeDataState: React.ComponentType<TreeDataStateProps>;

/***
  * A plugin that converts custom formatted tree data to a supported format and performs
  * local row expanding/collapsing.
  * */
export const CustomTreeData: React.ComponentType<CustomTreeDataProps>;

/** A plugin that renders a table column with a toggle button and sorting indicators. */
export const TableTreeColumn: React.ComponentType<TableTreeColumnProps>;

/** A plugin that manages the search state. */
export const SearchState: React.ComponentType<SearchStateProps>;

/** A plugin that renders the Search Panel. */
export const SearchPanel: React.ComponentType<SearchPanelProps>;

/** A plugin that enables you to fix columns to the left and right sides of the grid. */
export const TableFixedColumns: React.ComponentType<TableFixedColumnsProps>;

/** A plugin that provides items for total, group, and tree summaries. */
export const SummaryState: React.ComponentType<SummaryStateProps>;

/** A plugin that performs a built-in data summary calculation. */
export const IntegratedSummary: React.ComponentType<IntegratedSummaryProps> & {
  /** The built-in summary calculator. */
  defaultCalculator: (type: SummaryType, rows: Array<any>, getValue: (row: any) => any) => any;
};

/** A plugin that allows you to calculate a custom summary. */
export const CustomSummary: React.ComponentType<CustomSummaryProps>;

export class TableSummaryRowBase extends React.PureComponent<TableSummaryRowProps> {
  static TREE_ROW_TYPE: symbol;
  static GROUP_ROW_TYPE: symbol;
  static TOTAL_ROW_TYPE: symbol;
  static defaultProps: {
    formatlessSummaryTypes: never[];
    messages: {};
  };
  static components: {
    totalRowComponent: string;
    groupRowComponent: string;
    treeRowComponent: string;
    totalCellComponent: string;
    groupCellComponent: string;
    treeCellComponent: string;
    treeColumnCellComponent: string;
    treeColumnContentComponent: string;
    treeColumnIndentComponent: string;
    itemComponent: string;
  };
  renderContent(column: any, columnSummaries: any): JSX.Element;
  render(): JSX.Element;
}
/** A plugin that renders table rows that display a total, group, and tree summary. */
export const TableSummaryRow: React.ComponentType<TableSummaryRowProps> & {
  /** The tree summary row type's indentifier. */
  TREE_ROW_TYPE: symbol;
  /** The group summary row type's indentifier. */
  GROUP_ROW_TYPE: symbol;
  /** The total row type's indentifier. */
  TOTAL_ROW_TYPE: symbol;
};

export const VirtualTableState: React.ComponentType<VirtualTableStateProps>;

export const TableInlineCellEditing: React.ComponentType<TableInlineCellEditingProps>;

export const ExportPanel: React.ComponentType<any>;

export const TableKeyboardNavigation: React.ComponentType<TableKeyboardNavigationProps>;











export namespace VirtualTable {
    /** Describes additional column properties that the plugin can handle. */
    interface ColumnExtension {
        /** The name of the column to extend. */
        columnName: string;
        /** The table column width. */
        width?: number | string;
        /** The table column alignment. */
        align?: 'left' | 'right' | 'center';
        /** Specifies whether word wrap is enabled in a column's cells. */
        wordWrapEnabled?: boolean;
    }
}
export interface VirtualTableProps {
    /** The virtual table's height. */
    height: number | string;
    /***
      * Estimated row height. Specify the average value for a table whose rows have
      * different heights.
      **/
    estimatedRowHeight: number;
    /** Additional column properties that the plugin can handle. */
    columnExtensions?: Array<VirtualTable.ColumnExtension>;
    /** A component that renders a table. */
    tableComponent: React.ComponentType<object>;
    /** A component that renders a table head. */
    headComponent: React.ComponentType<object>;
    /** A component that renders a table body. */
    bodyComponent: React.ComponentType<any>;
    /** A component that renders a table footer. */
    footerComponent: React.ComponentType<object>;
    /** A component that renders a table's container. */
    containerComponent: React.ComponentType<object>;
    /** A component that renders a table cell. */
    cellComponent: React.ComponentType<Table.DataCellProps>;
    /** A component that renders a table row. */
    rowComponent: React.ComponentType<Table.DataRowProps>;
    /** A component that renders a table cell when the table is empty. */
    noDataCellComponent: React.ComponentType<Table.NoDataCellProps>;
    /** A component that renders a table row when the table is empty. */
    noDataRowComponent: React.ComponentType<Table.RowProps>;
    /** A component that renders a stub table row if the row type is not recognized. */
    stubRowComponent: React.ComponentType<Table.RowProps>;
    /** A component that renders a stub table cell if the cell value is not provided. */
    stubCellComponent: React.ComponentType<Table.CellProps>;
    /** A component that renders a stub header cell if the cell value is not provided. */
    stubHeaderCellComponent: React.ComponentType<Table.CellProps>;
    /** An object that specifies the localization messages. */
    messages?: Table.LocalizationMessages;
    skeletonCellComponent: React.ComponentType<Table.CellProps>;
    /** Handles top row changes. */
    onTopRowChange: (rowId: number | string | symbol | undefined) => void;
    /** A reference to the VirtualTable instance */
    ref?: React.RefObject<typeof VirtualTable>;
}
/** A plugin that renders a scrollable table instead of a static table. Contains the VirtualTable.Row and VirtualTable.Cell components that provide ways to customize virtual table rows and columns. These components can be extended by other plugins. */
export const VirtualTable: React.ComponentType<VirtualTableProps> & {
    /** The data column type's indentifier. */
    COLUMN_TYPE: symbol;
    /** The data row type's indentifier. */
    ROW_TYPE: symbol;
    /** The nodata row type's indentifier. */
    NODATA_ROW_TYPE: symbol;
};

/** Describes a row cache */
export interface RowCache {
  /** Returns `take` number of rows starting with the `skip` row from the cache */
  getRows(skip: number, take: number): any[];
  /** Adds `rows` to the cache */
  setRows(skip: number, rows: ReadonlyArray<any>): void;
  /** Clears the cache */
  invalidate(): void;
}

export const createRowCache: (pageSize?: number, capacity?: number) => RowCache;

export const withKeyboardNavigation: <T extends KeyboardNavigationComponent>(key1?: string, key2?: string) => (Component: React.ComponentType<Table.CellProps>) => React.ComponentType<T>;

export const InlineSummaryItem: React.FunctionComponent<TableGroupRow.InlineSummaryItemProps>;

export interface CustomSummaryProps {
  /** Total summary values. */
  totalValues?: Array<any>;
  /** Group summary values. */
  groupValues?: {
    [key: string]: Array<any>;
  };
  /** Tree summary values. */
  treeValues?: {
    [key: string]: Array<any>;
  };
}

export namespace ColumnChooser {
    /** Describes properties passed to a component that renders a column chooser item. */
    interface ItemProps {
        /** A column chooser item. */
        item: ColumnChooserItem;
        /** Specifies whether a column chooser item is disabled. */
        disabled: boolean;
        /** Handles an associated column's visibility changes. */
        onToggle(): void;
    }
    /** Describes properties passed to a component that renders the column chooser container. */
    interface ContainerProps {
        /** A React node used to render column chooser items. */
        children: React.ReactNode;
    }
    /*** Describes properties passed to a component that renders the button
      * that invokes the column chooser. */
    interface ToggleButtonProps {
        /** An event that initiates overlay showing or hiding. */
        onToggle(): void;
        /*** Returns a specified localization message.
          * Available in the "\@devexpress/dx-react-grid-material-ui" package. */
        getMessage: (messageKey: string) => string;
        /** A function that accepts the button's root React element. */
        buttonRef: (ref: React.ReactInstance) => void;
        active?: boolean;
    }
    /** Describes properties passed to a component that renders the column chooser overlay. */
    interface OverlayProps {
        /** Specifies whether the overlay is visible. */
        visible: boolean;
        /** A React component instance or a DOM element that is used for overlay positioning. */
        target: React.ReactInstance;
        /** An event that initiates overlay hiding. */
        onHide(): void;
        /** A React node used to render overlay content. */
        children: React.ReactNode;
    }
    interface LocalizationMessages {
        /*** The toggle button's tooltip text.
          * Available in the "\@devexpress/dx-react-grid-material-ui" package. */
        showColumnChooser?: string;
    }
}
export interface ColumnChooserProps {
    /** A component that renders the column chooser overlay. */
    overlayComponent: React.ComponentType<ColumnChooser.OverlayProps>;
    /** A component that renders a button that invokes the column chooser. */
    toggleButtonComponent: React.ComponentType<ColumnChooser.ToggleButtonProps>;
    /** A component that renders the column chooser container. */
    containerComponent: React.ComponentType<ColumnChooser.ContainerProps>;
    /** A component that renders a column chooser item. */
    itemComponent: React.ComponentType<ColumnChooser.ItemProps>;
    /** An object that specifies localization messages. */
    messages?: ColumnChooser.LocalizationMessages;
}

export interface TableColumnResizingProps {
  /** Specifies column widths. */
  columnWidths?: Array<TableColumnWidthInfo>;
  /** Specifies a column's minimum width. */
  minColumnWidth?: number;
  /** Specifies a column's maximum width. */
  maxColumnWidth?: number;
  /** Additional column properties that the plugin can handle. */
  columnExtensions?: Array<TableColumnResizing.ColumnExtension>;
  /** Specifies initial column widths in uncontrolled mode. */
  defaultColumnWidths?: Array<TableColumnWidthInfo>;
  /** Specifies initial column resize mode. */
  resizingMode?: string;
  /** Handles column width changes. */
  onColumnWidthsChange?: (nextColumnWidths: Array<TableColumnWidthInfo>) => void;
}
export type CellWidthGetter = () => number;

export namespace DragDropProvider {
  /** Describes properties of the component that renders a container for columns being dragged. */
  interface ContainerProps {
    /** The current offset of a column that is being dragged. The offset is measured against the application's client area. */
    clientOffset: {
      x: number;
      y: number;
    };
    /** A React node representing columns being dragged. */
    children: React.ReactNode;
  }
  /** Describes properties of the component that renders a column being dragged. */
  interface ColumnProps {
    /** Specifies a column being dragged. */
    column: Column;
  }
}
export interface DragDropProviderProps {
  /** A component that renders a container for columns being dragged. */
  containerComponent: React.ComponentType<DragDropProvider.ContainerProps>;
  /** A component that renders a column being dragged. */
  columnComponent: React.ComponentType<DragDropProvider.ColumnProps>;
}

export interface TableColumnReorderingProps {
  /** The column order. */
  order?: ReadonlyArray<string>;
  /** The initial column order in the uncontrolled mode. */
  defaultOrder?: Array<string>;
  /** Handles changes to the column order. */
  onOrderChange?: (nextOrder: Array<string>) => void;
}

export namespace TableColumnVisibility {
  /** Describes the empty message component's properties. */
  interface EmptyMessageProps {
    /** Returns the text displayed when all columns are hidden. */
    getMessage: (messageKey: string) => string;
  }
  /** Describes additional column properties that the plugin can handle. */
  interface ColumnExtension {
    /** The name of a column to extend. */
    columnName: string;
    /** Specifies whether an end-user can change column visibility. */
    togglingEnabled: boolean;
  }
  interface LocalizationMessages {
    /** Specifies the text that is displayed when the plugin does not contain visible columns. */
    noColumns?: string;
  }
}
export interface TableColumnVisibilityProps {
  /** Hidden column names. */
  hiddenColumnNames?: Array<string>;
  /** Names of initially hidden columns in the uncontrolled mode. */
  defaultHiddenColumnNames?: Array<string>;
  /** Specifies whether an end-user can change column visibility. */
  columnTogglingEnabled?: boolean;
  /** Additional column properties that the plugin can handle. */
  columnExtensions?: Array<TableColumnVisibility.ColumnExtension>;
  /** Handles hidden columns adding or removing. */
  onHiddenColumnNamesChange?: (hiddenColumnNames: Array<string>) => void;
  /** A component that renders a message that is displayed when all columns are hidden. */
  emptyMessageComponent: React.ComponentType<TableColumnVisibility.EmptyMessageProps>;
  /** An object that specifies localization messages. */
  messages?: TableColumnVisibility.LocalizationMessages;
}

export namespace TableFixedColumns {
  /** Describes properties passed to a component that renders a fixed column's cell. */
  interface CellProps extends Table.CellProps {
    /** Specifies the side of the table to which the cell should be fixed. */
    side: 'left' | 'right';
    /** A component that should be rendered as a fixed cell. */
    component: React.ComponentType<Table.CellProps>;
    /** Specifies whether to render the left divider. */
    showLeftDivider: boolean;
    /** Specifies whether to render the right divider. */
    showRightDivider: boolean;
    /** Specifies the fixed cell's position. */
    position: number;
  }
}
export interface TableFixedColumnsProps {
  /** Specifies names and types of the columns to be fixed to the left grid's side. */
  leftColumns?: Array<string | symbol>;
  /** Specifies names and types of the columns to be fixed to the right grid's side. */
  rightColumns?: Array<string | symbol>;
  /** A component that renders a fixed column's cell. */
  cellComponent: React.ComponentType<TableFixedColumns.CellProps>;
}

export namespace DataTypeProvider {
  /** Describes properties passed to a component that renders the formatted value. */
  interface ValueFormatterProps {
    /** A column object. */
    column: Column;
    /** A row. */
    row?: any;
    /** The value to be formatted. */
    value: any;
  }
  /** Describes properties passed to a component that renders the value editor. */
  interface ValueEditorProps {
    /** A column object. */
    column: Column;
    /** A row. */
    row?: any;
    /** Specifies the editor value. */
    value: any;
    /** Handles value changes. */
    onValueChange: (newValue: any) => void;
    /** "true" if users should not be able to edit the value; otherwise, "false". */
    disabled: boolean;
    /** "true" if the editor should be focused on render; otherwise "false". */
    autoFocus: boolean;
    /** Calls the `EditingState` plugin's `commitChanges` handler and switches the editor from edit state when it loses focus (used for Inline Cell Editing). */
    onBlur: () => void;
    /** Applies an action when the editor gets focus (used for Inline Cell Editing). */
    onFocus: () => void;
    /** Handles key press: Enter saves changes, Esc discards them and switches the editor from edit state (used for Inline Cell Editing). */
    onKeyDown: (e: {
      key: 'Escape' | 'Enter';
    }) => void;
  }
}
export interface DataTypeProviderProps {
  /** The names of columns associated with the specified formatter and editor. */
  for: Array<string>;
  /** A component that renders the formatted value. */
  formatterComponent?: React.ComponentType<DataTypeProvider.ValueFormatterProps>;
  /** A component that renders a custom editor. */
  editorComponent?: React.ComponentType<DataTypeProvider.ValueEditorProps>;
  /** The names of filter operations that are available for the associated columns. */
  availableFilterOperations?: Array<FilterOperation>;
}

export interface RowDetailStateProps {
  /** IDs of the rows being expanded. */
  expandedRowIds?: Array<number | string>;
  /** IDs of the rows initially expanded in the uncontrolled mode. */
  defaultExpandedRowIds?: Array<number | string>;
  /** Handles expanded rows changes. */
  onExpandedRowIdsChange?: (expandedRowIds: Array<number | string>) => void;
}
export namespace TableRowDetail {
  /** Describes properties passed to a component that renders a detail row's content. */
  interface ContentProps {
    /** A row. */
    row: any;
  }
  /** Describes properties passed to a component that renders a detail cell. */
  interface CellProps extends Table.CellProps {
    /** A row. */
    row: any;
    /** A detail cell's child React node. */
    children?: React.ReactNode;
  }
  /** Describes properties passed to a component that renders a detail row. */
  interface RowProps extends Table.RowProps {
    /** A row. */
    row: any;
  }
  /** Describes properties passed to a component that renders a cell containing the expand/collapse control. */
  interface ToggleCellProps extends Table.CellProps {
    /** A row. */
    row: any;
    /** Specifies whether to expand the detail row. */
    expanded: boolean;
    /** An event that initiates row expanding or collapsing. */
    onToggle(): void;
  }
}
export interface TableRowDetailProps {
  /** A component that renders the detail row's content within the detail cell. */
  contentComponent?: React.ComponentType<TableRowDetail.ContentProps>;
  /** A component that renders a detail cell. */
  cellComponent: React.ComponentType<TableRowDetail.CellProps>;
  /** A component that renders a detail row. */
  rowComponent: React.ComponentType<TableRowDetail.RowProps>;
  /** A component that renders a cell containing the expand/collapse control. */
  toggleCellComponent: React.ComponentType<TableRowDetail.ToggleCellProps>;
  /** Specifies the width of the column containing expand/collapse controls. */
  toggleColumnWidth: number;
  /** Specifies the detail row height. */
  rowHeight?: number;
}

export namespace EditingState {
  /** Describes additional column properties that the plugin can handle. */
  interface ColumnExtension {
    /** The name of a column to extend. */
    columnName: string;
    /** Specifies whether editing is enabled for a column. */
    editingEnabled?: boolean;
    /** A function that returns a value specifying row changes depending on the columns' editor values for the current row. This function is called each time the editor's value changes. */
    createRowChange?: (row: any, value: any, columnName: string) => any;
  }
}
/** Describes uncommitted changes made to the grid data. */
export interface ChangeSet {
  /** An array of rows to be created. */
  added?: ReadonlyArray<any>;
  /** An associative array that stores changes made to existing data. Each array item specifies changes made to a row. The item's key specifies the associated row's ID. */
  changed?: {
    [key: string]: any;
  };
  /** An array of IDs representing rows to be deleted. */
  deleted?: ReadonlyArray<number | string>;
}
export interface EditingStateProps {
  /** A function that returns a row change object depending on row editor values. This function is called each time the row editor's value changes. */
  createRowChange?: (row: any, value: string | number, columnName: string) => any;
  /** Specifies whether editing is enabled for all columns. */
  columnEditingEnabled?: boolean;
  /** Additional column properties that the plugin can handle. */
  columnExtensions?: Array<EditingState.ColumnExtension>;
  /** IDs of the rows being edited. */
  editingRowIds?: Array<number | string>;
  /** IDs of the rows initially added to the `editingRowIds` array in uncontrolled mode. */
  defaultEditingRowIds?: Array<number | string>;
  /** Row ID and column name of cells that are being edited. */
  editingCells?: Array<EditingCell>;
  /** Row ID and column name of cells initially added to the `editingCells` array in uncontrolled mode. */
  defaultEditingCells?: Array<EditingCell>;
  /** Handles adding or removing a row to/from the `editingRowIds` array. */
  onEditingRowIdsChange?: (editingRowIds: Array<number | string>) => void;
  /** Handles changing a cell to/from the `editingRowIds` array. */
  onEditingCellsChange?: (editingRowIds: Array<EditingCell>) => void;
  onDeletedRowIdsChange?: (deletedRowIds: Array<number | string>) => void;
  /** Created but not committed rows. */
  addedRows?: Array<any>;
  /** Rows initially added to the `addedRows` array in uncontrolled mode. */
  defaultAddedRows?: Array<any>;
  /** Handles adding or removing a row to/from the `addedRows` array. */
  onAddedRowsChange?: (addedRows: Array<any>) => void;
  /** Not committed row changes. */
  rowChanges?: {
    [key: string]: any;
  };
  /** Row changes initially added to the `rowChanges` array in uncontrolled mode. */
  defaultRowChanges?: {
    [key: string]: any;
  };
  /** Handles adding or removing a row changes to/from the `rowChanges` array. */
  onRowChangesChange?: (rowChanges: {
    [key: string]: any;
  }) => void;
  /** Handles row changes committing. */
  onCommitChanges: (changes: ChangeSet) => void;
}

export namespace TableEditColumn {
  /** Describes properties passed to a data row's command cell component. */
  interface CellProps extends Table.CellProps {
    /** Specifies an edited table row with the applied changes. */
    row: any;
    /** A React node to be placed in the command cell. */
    children?: React.ReactNode;
  }
  /** Describes properties passed to a component that renders a command cell within the header row. */
  interface HeaderCellProps extends Table.CellProps {
    /** A React node to be placed in the command cell. */
    children?: React.ReactNode;
  }
  /** Describes properties passed to a component that renders command control within a command cell. */
  interface CommandProps {
    /** The command identifier. */
    id: 'add' | 'edit' | 'delete' | 'commit' | 'cancel';
    /** The command action description. */
    text: string;
    /** An event initiating the command execution. */
    onExecute(): void;
  }
  interface LocalizationMessages {
    /** Specifies the add command button text. */
    addCommand?: string;
    /** Specifies the edit command button text. */
    editCommand?: string;
    /** Specifies the delete command button text. */
    deleteCommand?: string;
    /** Specifies the commit command button text. */
    commitCommand?: string;
    /** Specifies the cancel command button text. */
    cancelCommand?: string;
  }
}
export interface TableEditColumnProps {
  /** A component that renders a command cell within a data row. */
  cellComponent: React.ComponentType<TableEditColumn.CellProps>;
  /** A component that renders a command cell within the header row. */
  headerCellComponent: React.ComponentType<TableEditColumn.HeaderCellProps>;
  /** A component that renders command control within a command cell. */
  commandComponent: React.ComponentType<TableEditColumn.CommandProps>;
  /** Specifies whether to render the 'New' command within the header row's command cell. */
  showAddCommand?: boolean;
  /** Specifies whether to render the 'Edit' command within the data row's command cell. */
  showEditCommand?: boolean;
  /** Specifies whether to render the 'Delete' command within the data row's command cell. */
  showDeleteCommand?: boolean;
  /** Specifies the command column's width. */
  width?: number | string;
  /** An object that specifies the localization messages. */
  messages?: TableEditColumn.LocalizationMessages;
}

export namespace TableEditRow {
  /** Describes properties passed to a component that renders an editable cell. */
  interface CellProps extends Table.CellProps {
    /** A row to be edited. */
    row: any;
    /** A column. */
    column: Column;
    /** A value to be edited. */
    value: any;
    /** Specifies whether editing a column is enabled. */
    editingEnabled: boolean;
    /** Handles value changes. */
    onValueChange: (newValue: any) => void;
  }
  /** Describes properties passed to a component that renders an editable row. */
  interface RowProps extends Table.RowProps {
    /** A row to be edited. */
    row: any;
  }
}
export interface TableEditRowProps {
  /** A component that renders an editable cell. */
  cellComponent: React.ComponentType<TableEditRow.CellProps>;
  /** A component that renders an editable row. */
  rowComponent: React.ComponentType<TableEditRow.RowProps>;
  /** Specifies the editable row's height. */
  rowHeight?: number;
}

export namespace TableInlineCellEditing {
  /** Describes properties passed to a component that renders an editable cell. */
  interface CellProps extends Table.CellProps {
    /** A row to be edited. */
    row: any;
    /** A column. */
    column: Column;
    /** A value to be edited. */
    value: any;
    /** Specifies whether editing a column is enabled. */
    editingEnabled: boolean;
    /** Handles value changes. */
    onValueChange: (newValue: any) => void;
    /** AutoFocus on element */
    autoFocus: boolean;
    /** A function called on focus an element */
    onFocus: (e: any) => void;
    /** A function called on key down */
    onKeyDown: (e: any) => void;
    /** A function called on focus lost */
    onBlur: () => void;
  }
}
export interface TableInlineCellEditingProps {
  /** A component that renders an editable cell. */
  cellComponent: React.ComponentType<TableInlineCellEditing.CellProps>;
  /** Define text selection on edit start */
  selectTextOnEditStart: boolean;
  /** An action, that start editing cell */
  startEditAction: 'click' | 'doubleClick';
}

export namespace FilteringState {
  /** Describes additional column properties that the plugin can handle. */
  interface ColumnExtension {
    /** The name of a column to extend. */
    columnName: string;
    /** Specifies whether filtering is enabled for a column. */
    filteringEnabled: boolean;
  }
}
export interface FilteringStateProps {
  /** Specifies the applied filters. */
  filters?: Filter[];
  /** Specifies the filters initially applied in the uncontrolled mode. */
  defaultFilters?: Filter[];
  /** Handles filter changes. */
  onFiltersChange?: (filters: Filter[]) => void;
  /** Specifies whether filtering is enabled for all columns. */
  columnFilteringEnabled?: boolean;
  /** Additional column properties that the plugin can handle. */
  columnExtensions?: FilteringState.ColumnExtension[];
}

export namespace TableFilterRow {
  /** Describes properties passed to a component that renders a filter cell. */
  interface CellProps extends Table.CellProps {
    /** Filtering options that are applied to a column. */
    filter: Filter | null;
    /** An event that initiates applying a new filter to a column. */
    onFilter: (filter: Filter | null) => void;
    /** A column. */
    column: Column;
    /** Specifies whether filtering by column is enabled. */
    filteringEnabled: boolean;
    /** Returns the filter editor placeholder text. Available in the "\@devexpress/dx-react-grid-material-ui" package. */
    getMessage: (messageKey: string) => string;
  }
  /** Describes properties passed to a component that renders a filter selector. */
  interface FilterSelectorProps {
    /** A component that renders filter selector icons. */
    iconComponent: React.ComponentType<TableFilterRow.IconProps>;
    /** The currently selected filter operation. */
    value: string;
    /** The list of available filter operations. */
    availableValues: Array<string>;
    /** Handles filter operation changes. */
    onChange: (value: string) => void;
    /** Specifies whether the FilterSelector is disabled. */
    disabled: boolean;
    /** Returns the specified localization message. */
    getMessage: (messageKey: string) => string;
  }
  /** Describes properties passed to a component that renders a filter selector icon. */
  interface IconProps {
    /** Specifies the icon type. */
    type: string;
  }
  /** Describes properties passed to a component that renders a filter editor. */
  interface EditorProps {
    /** The current editor value. */
    value: any;
    /** Specifies whether the editor is disabled. */
    disabled: boolean;
    /** Handles filter value changes. */
    onChange: (value: string) => void;
    /** Returns the specified localization message. */
    getMessage: (messageKey: string) => string;
  }
  /** Describes properties passed to a component that renders a toggle button for a filter selector. */
  interface ToggleButtonProps {
    /** Specifies whether the editor is disabled. */
    disabled?: boolean;
    /** Handles filter value changes. */
    onToggle(): void;
    /** A function that accepts the button's root React element. */
    buttonRef: (ref: React.ReactInstance) => void;
    /** A React node used to render the button content. */
    children?: React.ReactNode;
  }
  interface LocalizationMessages {
    /** The filter editor placeholder text. */
    filterPlaceholder?: string;
    /** The 'contains' filter operation name. */
    contains?: string;
    /** The 'notContains' filter operation name. */
    notContains?: string;
    /** The 'startsWith' filter operation name. */
    startsWith?: string;
    /** The 'endsWith' filter operation name. */
    endsWith?: string;
    /** The 'equal' filter operation name. */
    equal?: string;
    /** The 'notEqual' filter operation name. */
    notEqual?: string;
    /** The 'greaterThan' filter operation name. */
    greaterThan?: string;
    /** The 'greaterThanOrEqual' filter operation name. */
    greaterThanOrEqual?: string;
    /** The 'lessThan' filter operation name. */
    lessThan?: string;
    /** The 'lessThanOrEqual' filter operation name. */
    lessThanOrEqual?: string;
    /** Additional filter operation names */
    [key: string]: string | undefined;
  }
}
export interface TableFilterRowProps {
  /** A component that renders a filter cell. */
  cellComponent: React.ComponentType<TableFilterRow.CellProps>;
  /** A component that renders a filter row. */
  rowComponent: React.ComponentType<Table.RowProps>;
  /** A component that renders a filter selector. */
  filterSelectorComponent: React.ComponentType<TableFilterRow.FilterSelectorProps>;
  /** A component that renders filter selector icons. */
  iconComponent: React.ComponentType<TableFilterRow.IconProps>;
  /** A component that renders a filter editor. */
  editorComponent: React.ComponentType<TableFilterRow.EditorProps>;
  /** A component that renders a filter selector's toggle button. */
  toggleButtonComponent: React.ComponentType<TableFilterRow.ToggleButtonProps>;
  /** Specifies whether the FilterSelector should be displayed. */
  showFilterSelector?: boolean;
  /** The filter row's height. */
  rowHeight?: number;
  /** An object that specifies localization messages. */
  messages?: TableFilterRow.LocalizationMessages;
}

export type IntegratedFilteringProps = {
  /** Additional column properties that the plugin can handle. */
  columnExtensions?: IntegratedFiltering.ColumnExtension[];
};
export type DefaultPredicateFn = (value: any, filter: Filter, row: any) => boolean;

export namespace Grid {
    /** Describes properties passed to a component that renders the grid root layout. */
    interface RootProps {
        /** A React node to be placed in the root layout. */
        children?: React.ReactNode;
    }
}
export type GridProps = React.PropsWithChildren<{
    /*** An array containing custom data. A user defines the access to this data.
      * Refer to Data Accessors for details. */
    rows: ReadonlyArray<any>;
    /** Specifies for which row fields columns are created. */
    columns: ReadonlyArray<Column>;
    /*** Specifies the function used to get a unique row identifier.
      * Define this function if the identifier is different than the row index. */
    getRowId?: (row: any) => number | string;
    /** Specifies the function used to get a cell's value. */
    getCellValue?: (row: any, columnName: string) => any;
    /** A component that renders the grid root layout. */
    rootComponent: React.ComponentType<Grid.RootProps>;
}>;

export interface CustomGroupingProps {
  /** A function that extracts groups from the specified data. It is executed recursively for the root and nested groups. */
  getChildGroups: (currentRows: Array<any>, grouping: Grouping, rootRows: Array<any>) => Array<{
    key: number | string;
    value?: any;
    childRows?: Array<any>;
  }>;
  /** Specifies columns by which data is grouped. */
  grouping?: Grouping[] | null;
  /** Specifies the expanded groups. */
  expandedGroups?: GroupKey[] | null;
}

export namespace TableGroupRow {
    /** Describes additional column properties that the plugin can handle. */
    interface ColumnExtension {
        /** The name of a column to extend. */
        columnName: string;
        /** Specifies whether the grid displays the column by which data is grouped. */
        showWhenGrouped?: boolean;
    }
    /** Describes properties passed to a component that renders a group cell. */
    interface CellProps extends Table.CellProps {
        /** The group row. */
        row: GroupRow;
        /** The column associated with the group. */
        column: Column;
        /** Specifies whether the row is expanded. */
        expanded: boolean;
        /** An event that initiates group row expanding or collapsing. */
        onToggle(): void;
        readonly inlineSummaries: Readonly<InlineSummaryItemInfo[]>;
        inlineSummaryComponent: React.ComponentType<InlineSummaryProps>;
        inlineSummaryItemComponent: React.ComponentType<InlineSummaryItemProps>;
        getMessage: (string: any) => string;
    }
    /** Describes properties passed to a component that renders a group row. */
    interface RowProps extends Table.RowProps {
        /** The group row. */
        row: GroupRow;
    }
    /** Describes properties passed to a component that renders a group cell content. */
    interface ContentProps {
        /** The group row. */
        row: GroupRow;
        /** The column associated with the group. */
        column: Column;
        /** A React node to be rendered within the cell content. */
        children?: React.ReactNode;
    }
    /** Describes properties passed to a component that renders a group expand icon. */
    interface IconProps {
        /** Specifies whether the row is expanded. */
        expanded: boolean;
    }
    interface ContainerProps {
        children: React.ReactNode;
        style: object;
    }
    /** Describes properties passed to a component that renders a group indent cell. */
    interface IndentCellProps extends Table.CellProps {
        /** The group row. */
        row: GroupRow;
        /** A column associated with the group. */
        column: Column;
    }
    interface InlineSummaryItemProps {
        getMessage: GetMessageFn;
        summary: InlineSummaryItemInfo;
    }
    interface InlineSummaryProps {
        getMessage: GetMessageFn;
        readonly inlineSummaries: InlineSummaryItemInfo[];
        inlineSummaryItemComponent: React.ComponentType<InlineSummaryItemProps>;
    }
    interface SummaryCellProps extends Table.CellProps {
        /** The group row. */
        row: GroupRow;
        /** The column associated with the group. */
        column: Column;
        onToggle(): void;
    }
    interface StubCellProps extends Table.CellProps {
        onToggle(): void;
    }
    interface LocalizationMessages extends TableSummaryRow.LocalizationMessages {
        countOf?: string;
        sumOf?: string;
        maxOf?: string;
        minOf?: string;
        avgOf?: string;
    }
    type InlineSummaryItemInfo = ColumnSummary & {
        columnTitle: string | undefined;
        messageKey: string;
        component: React.FunctionComponent<any>;
    };
}
/** Describes the group row structure. */
export interface GroupRow {
    /** The current group key. */
    key: number | string;
    /** The current group value. */
    value: any;
}
export interface TableGroupRowProps {
    /***
      * A Boolean value that specifies whether the grid's table
      * displays a column by which data is grouped.
      **/
    showColumnsWhenGrouped?: boolean;
    /** Additional column properties that the plugin can handle. */
    columnExtensions?: Array<TableGroupRow.ColumnExtension>;
    /** A component that renders a group cell. */
    cellComponent: React.ComponentType<TableGroupRow.CellProps>;
    /** A component that renders a group row. */
    rowComponent: React.ComponentType<TableGroupRow.RowProps>;
    /** A component that renders a group cell content. */
    contentComponent: React.ComponentType<TableGroupRow.ContentProps>;
    /** A component that renders a group expand icon. */
    iconComponent: React.ComponentType<TableGroupRow.IconProps>;
    inlineSummaryItemComponent: React.ComponentType<TableGroupRow.InlineSummaryItemProps>;
    inlineSummaryComponent: React.ComponentType<TableGroupRow.InlineSummaryProps>;
    summaryCellComponent: React.ComponentType<TableGroupRow.SummaryCellProps>;
    summaryItemComponent: React.ComponentType<TableSummaryRow.ItemProps>;
    stubCellComponent: React.ComponentType<TableGroupRow.StubCellProps>;
    /** A component that renders a content container */
    containerComponent: React.ComponentType<TableGroupRow.ContainerProps>;
    /** A component that renders a group indent cell. */
    indentCellComponent?: React.ComponentType<TableGroupRow.IndentCellProps>;
    /** The group indent column's width. */
    indentColumnWidth: number;
    messages?: TableGroupRow.LocalizationMessages;
    formatlessSummaryTypes: string[];
    /** The group cell's left padding value */
    contentCellPadding: string;
}

export namespace GroupingPanel {
    /** Describes properties passed to a component that renders a group panel container. */
    interface ContainerProps {
        /** A React node to be placed in the root layout. */
        children?: React.ReactNode;
        /** A reference to the group panel container or a function that accepts it. */
        forwardedRef?: React.RefObject<Element>;
    }
    /** Describes properties passed to a group panel item template when it is being rendered. */
    interface ItemProps {
        /** The Grouping Panel item. */
        item: GroupingPanelItem;
        /** Specifies whether to display a button that cancels grouping by column. */
        showGroupingControls: boolean;
        /** Specifies whether to render controls that toggle the column's sorting state. */
        showSortingControls: boolean;
        /** Specifies whether grouping by a column is enabled. */
        groupingEnabled: boolean;
        /** Specifies whether sorting by a column is enabled. */
        sortingEnabled: boolean;
        /** Specifies the sorting direction. */
        sortingDirection?: 'asc' | 'desc';
        /*** An event that initiates changing the column sorting direction.
          * Cancels sorting by the current column if `direction` is set to null. */
        onSort: (parameters: {
            direction?: 'asc' | 'desc' | null;
            keepOther?: boolean;
        }) => void;
        /** An event that initiates grouping by column. */
        onGroup: () => void;
        /** A reference to the group panel item or a function that accepts it. */
        forwardedRef?: React.Ref<Element>;
    }
    /** Describes properties passed to a component that renders an empty group panel message. */
    interface EmptyMessageProps {
        /** Returns the text displayed in the group panel if grid data is not grouped. */
        getMessage: (messageKey: string) => string;
        /** A reference to the group panel message or a function that accepts it. */
        forwardedRef?: React.Ref<Element>;
    }
    interface LocalizationMessages {
        /** The text displayed in the group panel if the grid is not grouped. */
        groupByColumn?: string;
    }
}
export interface GroupingPanelProps {
    /*** Specifies whether to render controls that toggle the column's sorting state.
      * Requires the SortingState dependency. */
    showSortingControls?: boolean;
    /** Specifies whether column headers display a button that cancels grouping by that column. */
    showGroupingControls?: boolean;
    /** A component that renders a group panel container. */
    containerComponent: React.ComponentType<GroupingPanel.ContainerProps>;
    /** A component that renders a group panel item. */
    itemComponent: React.ComponentType<GroupingPanel.ItemProps>;
    /** A component that renders an empty group panel message. */
    emptyMessageComponent: React.ComponentType<GroupingPanel.EmptyMessageProps>;
    /** An object that specifies the localization messages. */
    messages?: GroupingPanel.LocalizationMessages;
}

export namespace GroupingState {
  /** Describes additional column properties that the plugin can handle. */
  interface ColumnExtension {
    /** The name of a column to extend. */
    columnName: string;
    /** Specifies whether grouping is enabled for a column. */
    groupingEnabled: boolean;
  }
}
export interface GroupingStateProps {
  /** Specifies columns to group by. */
  grouping?: Array<Grouping>;
  /** Specifies initial grouping options in the uncontrolled mode. */
  defaultGrouping?: Array<Grouping>;
  /** Handles grouping option changes. */
  onGroupingChange?: (grouping: Array<Grouping>) => void;
  /** Specifies expanded groups. */
  expandedGroups?: Array<GroupKey>;
  /** Specifies initially expanded groups in the uncontrolled mode. */
  defaultExpandedGroups?: Array<GroupKey>;
  /** Specifies whether grouping is enabled for all columns. */
  columnGroupingEnabled?: boolean;
  /** Additional column properties that the plugin can handle. */
  columnExtensions?: Array<GroupingState.ColumnExtension>;
  /** Handles expanded group changes. */
  onExpandedGroupsChange?: (expandedGroups: Array<GroupKey>) => void;
}

export namespace IntegratedGrouping {
  /** Describes additional column properties that the plugin can handle. */
  interface ColumnExtension {
    /** The name of a column to extend. */
    columnName: string;
    /** A grouping criterion function. It returns an object with the **key** field by which data is grouped. If you need to group data by a non-primitive value (for example, a date), assign its string representation to the **key** field and the value to the **value** field. */
    criteria?: (value: any) => {
      key: string | number;
      value?: any;
    };
  }
}
export interface IntegratedGroupingProps {
  /** Additional column properties that the plugin can handle. */
  columnExtensions?: Array<IntegratedGrouping.ColumnExtension>;
}

export namespace TableBandHeader {
  /** Describes properties passed to a component that renders a table band cell. */
  interface CellProps extends Table.CellProps {
    /** A React node used to render band cell content. */
    children?: React.ReactNode;
    /** Specifies whether to show the left border. */
    beforeBorder?: boolean;
  }
  /** Describes properties of column bands that the TableBandHeader plugin renders. */
  interface ColumnBands {
    /** A column name that is used to identify a column in the bands tree. */
    columnName?: string;
    /** The band's title. Used only for bands and ignored for columns. */
    title?: string;
    /** Nested bands and columns. */
    children?: Array<TableBandHeader.ColumnBands>;
  }
}
export interface TableBandHeaderProps {
  /** A component that renders a band cell. */
  cellComponent: React.ComponentType<TableBandHeader.CellProps>;
  /** A component that renders a band cells' row. */
  rowComponent: React.ComponentType<Table.RowProps>;
  /** Specifies column bands for multi-level table header. */
  columnBands: Array<TableBandHeader.ColumnBands>;
}

export namespace TableHeaderRow {
  /** Describes properties used to render a table header cell. */
  interface CellProps extends Table.CellProps {
    /** A column object associated with the header cell. */
    column: Column;
    /** Specifies whether the column's resizing is enabled. */
    resizingEnabled: boolean;
    /** An event that initiates the column width change. The initial column width increases by the `shift` value or decreases if `shift` is negative. */
    onWidthChange: (parameters: {
      shift: number;
    }) => void;
    /** An event that changes the column width used for preview. The initial column width increases by the `shift` value or decreases if `shift` is less than zero. */
    onWidthDraft: (parameters: {
      shift: number;
    }) => void;
    /** An event that cancels the column width change used for preview. */
    onWidthDraftCancel(): void;
    /** The header cell's getter, which provide width */
    getCellWidth: (getter: CellWidthGetter) => void;
    /** Specifies whether drag-and-drop is enabled. */
    draggingEnabled: boolean;
    /** The header cell's children. */
    children: React.ReactNode;
  }
  /** Describes properties used to render a sort label. */
  interface SortLabelProps {
    /** A column object associated with the sort label. */
    column: Column;
    /** The sort label alignment. */
    align: string;
    /** The sorting direction. */
    direction: 'asc' | 'desc' | null;
    /** An event that invokes a sorting direction change. Keeps the current sorting state if `keepOther` is set to true. Cancels sorting by the current column if `direction` is set to null. */
    onSort: (parameters: {
      direction?: 'asc' | 'desc' | null;
      keepOther?: boolean;
    }) => void;
    /** Specifies whether the sort label is disabled. */
    disabled: boolean;
    /** Returns the sort label's text. */
    getMessage: (messageKey: string) => string;
    /** The sort label's children. */
    children: React.ReactNode;
  }
  /** Describes properties used to render a cell content. */
  interface ContentProps {
    /** A column object associated with the cell content. */
    column: Column;
    /** The content alignment. */
    align: string;
    /** The content's children. */
    children: React.ReactNode;
  }
  /** Describes properties used to render a group button. */
  interface GroupButtonProps {
    /** Specifies whether the group button is disabled. */
    disabled: boolean;
    /** An event that invokes grouping by the associated column. */
    onGroup(): void;
  }
  interface LocalizationMessages {
    /** Specifies the 'Sort' hint's text. Available in the "\@devexpress/dx-react-grid-material-ui" package. */
    sortingHint?: string;
  }
}
export interface TableHeaderRowProps {
  /** A component that renders a header cell. */
  cellComponent: React.ComponentType<TableHeaderRow.CellProps>;
  /** A component that renders a header row. */
  rowComponent: React.ComponentType<Table.RowProps>;
  /** A component that renders a header cell's content. */
  contentComponent: React.ComponentType<TableHeaderRow.ContentProps>;
  /** A component that renders a sort label. */
  sortLabelComponent: React.ComponentType<TableHeaderRow.SortLabelProps>;
  /** A component that renders a title. */
  titleComponent: React.ComponentType<object>;
  /** A component that renders a group button. */
  groupButtonComponent: React.ComponentType<TableHeaderRow.GroupButtonProps>;
  /** Specifies whether to render controls that toggle the column's sorting state. Requires the SortingState dependency. */
  showSortingControls?: boolean;
  /** Specifies whether to display a button that groups data by column. Requires the GroupingState dependency. */
  showGroupingControls?: boolean;
  /** An object that specifies localization messages. */
  messages?: TableHeaderRow.LocalizationMessages;
}





export interface CustomPagingProps {
  /** The total row count. */
  totalCount?: number;
}

export interface IntegratedPagingProps {
}

export namespace PagingPanel {
    /** Describes the container component properties. */
    interface ContainerProps {
        /** Specifies the total page count. */
        totalPages: number;
        /** Specifies the current page. */
        currentPage: number;
        /** Handles the current page changes. */
        onCurrentPageChange: (page: number) => void;
        /** Specifies the page size. */
        pageSize: number;
        /** Specifies the total row count. */
        totalCount: number;
        /** Handles the page size changes. */
        onPageSizeChange: (size: number) => void;
        /** Specifies the page sizes that a user can select. */
        pageSizes: Array<number>;
        /** Returns the paging panel's text. */
        getMessage: (messageKey: string, parameters?: {
            from: number;
            to: number;
            count: number;
        }) => string;
    }
    interface LocalizationMessages {
        /** Specifies the page size selector's 'All' item text. */
        showAll?: string;
        /*** Specifies the 'Rows per page' label's text.
          * Available in the "\@devexpress/dx-react-grid-material-ui" package. */
        rowsPerPage?: string;
        /** Specifies the 'Row count' text template. */
        info?: (parameters: {
            from: number;
            to: number;
            count: number;
        }) => string | string;
    }
}
export interface PagingPanelProps {
    /** A component that renders the paging panel. */
    containerComponent: React.ComponentType<PagingPanel.ContainerProps>;
    /** The page sizes that a user can select. */
    pageSizes?: Array<number>;
    /** An object that specifies the localization messages. */
    messages?: PagingPanel.LocalizationMessages;
}

export interface PagingStateProps {
  /** Specifies the current page number. */
  currentPage?: number;
  /** Specifies the initial page in uncontrolled mode. */
  defaultCurrentPage?: number;
  /** Handles current page changes. */
  onCurrentPageChange?: (currentPage: number) => void;
  /** Specifies the page size. Set this property to `0` to show all rows on a page. */
  pageSize?: number;
  /** Specifies the initial page size in uncontrolled mode. */
  defaultPageSize?: number;
  /** Handles page size changes. */
  onPageSizeChange?: (pageSize: number) => void;
}

export namespace SearchPanel {
  /** Describes properties passed to a component that renders the Search Panel root element. */
  interface InputProps {
    /** Specifies the search value. */
    value: string;
    /** Handles the search value changes. */
    onValueChange: (value: string) => void;
    /** Returns a specified localization message. */
    getMessage: (messageKey: string) => string;
  }
  interface LocalizationMessages {
    /** The search editor placeholder text. */
    searchPlaceholder?: string;
  }
}
export interface SearchPanelProps {
  /** A component that renders the Search Panel input element. */
  inputComponent: React.ComponentType<SearchPanel.InputProps>;
  /** An object that specifies localization messages. */
  messages?: SearchPanel.LocalizationMessages;
}

export interface SearchStateProps {
  /** Specifies the applied search value. */
  value?: string;
  /** Specifies the search value initially applied in the uncontrolled mode. */
  defaultValue?: string;
  /** Handles search value changes. */
  onValueChange?: (value: string) => void;
}

export interface IntegratedSelectionProps {
}

export interface SelectionStateProps {
  /** The selected row's IDs. */
  selection?: Array<number | string>;
  /** The initially selected rows in the uncontrolled mode. */
  defaultSelection?: Array<number | string>;
  /** Handles selection changes. */
  onSelectionChange?: (selection: Array<number | string>) => void;
}

export namespace TableSelection {
  /** Describes properties passed to a component that renders a cell containing the Select All checkbox. */
  interface HeaderCellProps extends Table.CellProps {
    /** Indicates if there are no rows that can be selected. */
    disabled: boolean;
    /** Indicates whether all the rows available for selection are selected. */
    allSelected: boolean;
    /** Indicates whether at least one but not all rows available for selection are selected. */
    someSelected: boolean;
    /** Toggles the Select All checkbox state. */
    onToggle: (select?: boolean) => void;
  }
  /** Describes properties passed to a component that renders a cell containing a selection checkbox. */
  interface CellProps extends Table.CellProps {
    /** A row. */
    row: any;
    /** Indicates whether a row is selected. */
    selected: boolean;
    /** An event that initiates row selecting or deselecting. */
    onToggle(): void;
  }
  /** Describes properties passed to a component that renders a selection row. */
  interface RowProps extends Table.RowProps {
    /** Indicates whether a row is highlighted. */
    highlighted?: boolean;
    /** Indicates if row can be selected by click. */
    selectByRowClick?: boolean;
    /** An event that initiates row selecting or deselecting. */
    onToggle(): void;
  }
}
export interface TableSelectionProps {
  /** Specifies whether to highlight the selected rows. Note that `Table` plugin's `rowComponent` is ignored in this case. */
  highlightRow?: boolean;
  /** Specifies whether a user can select/deselect a row by clicking it. Note that `Table` plugin's `rowComponent` is ignored in this case. */
  selectByRowClick?: boolean;
  /** Specifies whether to render the Select All checkbox in the header row. */
  showSelectAll?: boolean;
  /** Specifies whether to render the selection column that displays selection checkboxes. */
  showSelectionColumn?: boolean;
  /** A component that renders a selection cell . */
  cellComponent: React.ComponentType<TableSelection.CellProps>;
  /** A component that renders a cell containing the Select All checkbox. */
  headerCellComponent: React.ComponentType<TableSelection.HeaderCellProps>;
  /** The selection column's width. */
  selectionColumnWidth: number;
  /** A component that renders a selection row . */
  rowComponent: React.ComponentType<TableSelection.RowProps>;
}

export namespace IntegratedSorting {
  /** Describes additional column properties that the plugin can handle. */
  interface ColumnExtension {
    /** The name of a column to extend. */
    columnName: string;
    /** A sort compare function. See the Sorting guide for more information. */
    compare?: (a: any, b: any) => number;
  }
}
export interface IntegratedSortingProps {
  /** Additional column properties that the plugin can handle. */
  columnExtensions?: Array<IntegratedSorting.ColumnExtension>;
}

export namespace SortingState {
  /** Describes additional column properties that the plugin can handle. */
  interface ColumnExtension {
    /** The name of a column to extend. */
    columnName: string;
    /** Specifies whether sorting is enabled for a column. */
    sortingEnabled: boolean;
  }
}
export interface SortingStateProps {
  /** Specifies the applied sorting. */
  sorting?: Array<Sorting>;
  /** Specifies initial sorting in the uncontrolled mode. */
  defaultSorting?: Array<Sorting>;
  /** Specifies whether sorting is enabled for all columns. */
  columnSortingEnabled?: boolean;
  /** Additional column properties that the plugin can handle. */
  columnExtensions?: Array<SortingState.ColumnExtension>;
  /** Handles sorting changes. */
  onSortingChange?: (sorting: Array<Sorting>) => void;
}

export interface IntegratedSummaryProps {
  /** A summary calculator. */
  calculator?: (type: SummaryType, rows: Array<any>, getValue: (row: any) => any) => any;
}

export interface SummaryStateProps {
  /** The total summary items. */
  totalItems?: Array<SummaryItem>;
  /** The group summary items. */
  groupItems?: Array<GroupSummaryItem>;
  /** The tree summary items. */
  treeItems?: Array<SummaryItem>;
}

export namespace TableSummaryRow {
  /** Describes properties passed to a component that renders a cell in a summary row. */
  interface CellProps extends Table.CellProps {
    /** Specifies the cell's column. */
    column: Column;
    /** A React node to be rendered within the cell. */
    children?: React.ReactNode;
  }
  /** Describes properties passed to a component that renders a cell's content. */
  interface ContentProps {
    /** A React node to be rendered within the cell's content. */
    children?: React.ReactNode;
  }
  interface IndentProps {
    /** Specifies the row's level. */
    level: number;
  }
  /** Describes properties passed to a component that renders a summary item. */
  interface ItemProps {
    /** The summary value */
    value?: number | null;
    /** The summary type */
    type: SummaryType;
    /** A React node used to render the summary value. */
    children?: React.ReactNode;
    /** Returns a localization message by the message key. */
    getMessage: GetMessageFn;
  }
  interface LocalizationMessages {
    /** Specifies the count type's text. */
    count?: string;
    /** Specifies the summary type's text. */
    sum?: string;
    /** Specifies the minimum type's text. */
    min?: string;
    /** Specifies the maximum type's text. */
    max?: string;
    /** Specifies the average type text. */
    avg?: string;
  }
}
export interface TableSummaryRowProps {
  /** An array of summary types that the `DataTypeProvider` plugin should not format. */
  formatlessSummaryTypes: Array<string>;
  /** A component that renders the total summary row. */
  totalRowComponent: React.ComponentType<Table.RowProps>;
  /** A component that renders a group summary row. */
  groupRowComponent: React.ComponentType<Table.RowProps>;
  /** A component that renders a tree summary row. */
  treeRowComponent: React.ComponentType<Table.RowProps>;
  /** A component that renders a total summary cell. */
  totalCellComponent: React.ComponentType<TableSummaryRow.CellProps>;
  /** A component that renders a group summary cell. */
  groupCellComponent: React.ComponentType<TableSummaryRow.CellProps>;
  /** A component that renders a tree summary cell. */
  treeCellComponent: React.ComponentType<TableSummaryRow.CellProps>;
  /** A component that renders a summary cell within a tree column. */
  treeColumnCellComponent: React.ComponentType<TableSummaryRow.CellProps>;
  /** A component that renders a summary cell's content within a tree column. */
  treeColumnContentComponent: React.ComponentType<TableSummaryRow.ContentProps>;
  /** A component that renders an indent used to identify a tree row level within a tree column. */
  treeColumnIndentComponent: React.ComponentType<TableSummaryRow.IndentProps>;
  /** A component that renders a summary item. */
  itemComponent: React.ComponentType<TableSummaryRow.ItemProps>;
  /** An object that specifies localization messages. */
  messages?: TableSummaryRow.LocalizationMessages;
}

export namespace Table {
  /** Describes additional column properties that the plugin can handle. */
  interface ColumnExtension {
    /** The name of the column to extend. */
    columnName: string;
    /** The table column width. */
    width?: number | string;
    /** The table column alignment. */
    align?: 'left' | 'right' | 'center';
    /** Specifies whether word wrap is enabled in a column's cells. */
    wordWrapEnabled?: boolean;
  }
  /** Describes properties passed to a component that renders a generic table cell. */
  interface CellProps {
    /** Specifies a table row. */
    tableRow: TableRow;
    /** Specifies a table column. */
    tableColumn: TableColumn;
    /** The count of columns that the root cell element spans. */
    colSpan?: number;
    /** The count of rows that the root cell element spans. */
    rowSpan?: number;
  }
  /** Describes properties passed to a component that renders a table cell. */
  interface DataCellProps extends Table.CellProps {
    /** Specifies a value to be rendered within the cell. */
    value: any;
    /** Specifies the cell's row. */
    row: any;
    /** Specifies the cell's column. */
    column: Column;
    /** A React node used to render the cell content. */
    children?: React.ReactNode;
  }
  /** Describes properties passed to a component that renders a table cell when the table is empty. */
  interface NoDataCellProps extends Table.CellProps {
    /** Returns the text displayed in a cell when a table is empty. */
    getMessage: (messageKey: string) => string;
  }
  /** Describes properties passed to a component that renders a generic table row. */
  interface RowProps {
    /** A table row. */
    tableRow: TableRow;
    /** A React node used to render a table row. */
    children: React.ReactNode;
  }
  /** Describes properties passed to a component that renders a table row. */
  interface DataRowProps extends Table.RowProps {
    /** A row. */
    row: any;
    forwardedRef?: React.Ref<React.ReactInstance>;
  }
  interface LocalizationMessages {
    /** Specifies text shown when the Grid does not contain data. */
    noData?: string;
  }
  interface InnerTableProps {
    forwardedRef?: React.RefObject<HTMLTableElement>;
    style: React.CSSProperties;
  }
}
export interface TableProps {
  /** Additional column properties that the plugin can handle. */
  columnExtensions?: Array<Table.ColumnExtension>;
  /** A component that renders a table. */
  tableComponent: React.ComponentType<Table.InnerTableProps>;
  /** A component that renders a table head. */
  headComponent: React.ComponentType<object>;
  /** A component that renders a table body. */
  bodyComponent: React.ComponentType<any>;
  /** A component that renders a table footer. */
  footerComponent: React.ComponentType<object>;
  /** A component that renders a table's container. */
  containerComponent: React.ComponentType<object>;
  /** A component that renders a table cell. */
  cellComponent: React.ComponentType<Table.DataCellProps>;
  /** A component that renders a table row. */
  rowComponent: React.ComponentType<Table.DataRowProps>;
  /** A component that renders a table cell when the table is empty. */
  noDataCellComponent: React.ComponentType<Table.NoDataCellProps>;
  /** A component that renders a table row when the table is empty. */
  noDataRowComponent: React.ComponentType<Table.RowProps>;
  /** A component that renders a stub table row if the row type is not recognized. */
  stubRowComponent: React.ComponentType<Table.RowProps>;
  /** A component that renders a stub table cell if the cell value is not provided. */
  stubCellComponent: React.ComponentType<Table.CellProps>;
  /** A component that renders a stub header cell if the cell value is not provided. */
  stubHeaderCellComponent: React.ComponentType<Table.CellProps>;
  /** An object that specifies the localization messages. */
  messages?: Table.LocalizationMessages;
}

export interface VirtualTableStateProps {
  infiniteScrolling: boolean;
  skip: number;
  totalRowCount: number;
  pageSize?: number;
  loading: boolean;
  getRows: (skip: number, take: number) => void;
}

export namespace Toolbar {
  /** Describes properties passed to a component that renders the toolbar root element. */
  interface RootProps {
    /** A React node to be placed in the toolbar. */
    children?: React.ReactNode;
  }
}
export interface ToolbarProps {
  /** A component that renders the toolbar root element. */
  rootComponent: React.ComponentType<Toolbar.RootProps>;
}

export interface CustomTreeDataProps {
  /** A function that extracts child rows from the specified data. It is executed recursively for the root and nested rows. The `currentRow` parameter is `null` for root rows. The return value should be null if a row is a leaf, otherwise, it should be an array of rows. If child rows are not available, the function should return an empty array. */
  getChildRows: (currentRow: any | null, rootRows: Array<any>) => Array<any> | null;
}

export namespace TableTreeColumn {
  /** Describes properties passed to a component that renders a cell within a data row. */
  interface CellProps extends Table.CellProps {
    /** Specifies a value to be rendered within the cell. */
    value: any;
    /** Specifies the cell's row. */
    row: any;
    /** Specifies the cell's column. */
    column: Column;
    /** A React node to be rendered within the cell. */
    children?: React.ReactNode;
  }
  /** Describes properties passed to a component that renders a cell's content. */
  interface ContentProps {
    /** A React node to be rendered within the cell's content. */
    children?: React.ReactNode;
  }
  /** Describes properties passed to a component that renders an indent used to identify a row level. */
  interface IndentProps {
    /** Specifies the row level. */
    level: number;
  }
  /** Describes properties passed to a component that renders a button used to controls a row's expanded state. */
  interface ExpandButtonProps {
    /** Specifies whether to show the button. */
    visible: boolean;
    /** Specifies whether a row is expanded. */
    expanded: boolean;
    /** An event that initiates row expanding or collapsing. */
    onToggle(): void;
  }
  /** Describes properties passed to a component that renders a checkbox used to control selection. */
  interface CheckboxProps {
    /** Specifies whether a row is unavailable for selection. */
    disabled: boolean;
    /** Specifies whether a row is selected. */
    checked: boolean;
    /** Specifies whether a row's children are partially selected. */
    indeterminate: boolean;
    /** An event that initiates row selecting or deselecting. */
    onChange(): void;
  }
}
export interface TableTreeColumnProps {
  /** The name of a column that should be represented as a tree. */
  for: string;
  /** A component that renders a cell within a data row. */
  cellComponent: React.ComponentType<TableTreeColumn.CellProps>;
  /** A component that renders a cell's content. */
  contentComponent: React.ComponentType<TableTreeColumn.ContentProps>;
  /** A component that renders an indent used to identify a row level. */
  indentComponent: React.ComponentType<TableTreeColumn.IndentProps>;
  /** A component that renders a button that controls the row's expanded state. */
  expandButtonComponent: React.ComponentType<TableTreeColumn.ExpandButtonProps>;
  /** A component that renders a checkbox used to control selection. */
  checkboxComponent: React.ComponentType<TableTreeColumn.CheckboxProps>;
  /** Specifies whether to render selection controls. Requires the SelectionState plugin. */
  showSelectionControls?: boolean;
  /** Specifies whether to render Select All checkbox. Requires the IntegratedSelection plugin. */
  showSelectAll?: boolean;
}

export interface TreeDataStateProps {
  /** IDs of the rows being expanded. */
  expandedRowIds?: Array<number | string>;
  /** IDs of the rows that are initially expanded in the uncontrolled mode. */
  defaultExpandedRowIds?: Array<number | string>;
  /** Handles expanded rows changes. */
  onExpandedRowIdsChange?: (expandedRowIds: Array<number | string>) => void;
}
export type TreeDataStateState = {
  expandedRowIds: Array<number | string>;
};

export namespace ExportPanel {
    /*** Describes properties passed to a component that renders the button
      * that invokes the export menu. */
    interface ToggleButtonProps {
        /** A function that accepts the button's root React element. */
        buttonRef: (ref: React.ReactInstance) => void;
        /** An event that initiates menu showing or hiding. */
        onToggle(): void;
        /*** Returns a specified localization message.
          * Available in the "\@devexpress/dx-react-grid-material-ui" package. */
        getMessage: (messageKey: string) => string;
    }
    /** Describes properties passed to a component that renders the export menu. */
    interface MenuProps {
        /** Specifies whether the menu is visible. */
        visible: boolean;
        /** A React component instance or a DOM element that is used for menu positioning. */
        target: React.ReactInstance;
        /** An event that initiates menu hiding. */
        onHide(): void;
        /** A React node used to render menu content. */
        children: React.ReactNode;
    }
    interface MenuItemProps {
        /** A menu item text */
        text: string;
        /** An events that initiates export */
        onClick(): void;
    }
    interface LocalizationMessages {
        showExportMenu?: string;
        exportAll?: string;
        exportSelected?: string;
    }
}
export interface ExportPanelProps {
    /** A component that renders a button that invokes export menu. */
    toggleButtonComponent: React.ComponentType<ExportPanel.ToggleButtonProps>;
    /** A component that renders the Export Panel menu. */
    menuComponent: React.ComponentType<ExportPanel.MenuProps>;
    /** A component that renders the Export Panel menu item. */
    menuItemComponent: React.ComponentType<ExportPanel.MenuItemProps>;
    /** A function that initiates export. */
    startExport(config?: object): void;
    /** An object that specifies localization messages. */
    messages?: ExportPanel.LocalizationMessages;
}

export namespace TableKeyboardNavigation {
  /** Describes properties passed to a component that renders a keyboard navigation. */
  interface CellProps extends Table.CellProps, Required<ExtraProps> {
    /** A component that should be rendered as a focused cell. */
    component: React.ComponentType<Table.CellProps>;
  }
  interface RowProps extends Table.RowProps {
    /** A component that should be rendered as a focused cell. */
    component: React.ComponentType<Table.RowProps>;
  }
  interface ExtraProps {
  }
}
export interface TableKeyboardNavigationProps {
  /** Specifies initially focused cell in the uncontrolled mode. */
  defaultFocusedCell?: FocusedCell;
  /** Specifies focused cell. */
  focusedCell?: FocusedCell;
  /** Handles focused cell changes. */
  onFocusedCellChange?: OnFocusedCellChangeFn;
  /** A component that renders the cell element. */
  cellComponent: React.ComponentType<TableKeyboardNavigation.CellProps>;
  /** A component that renders the row element. */
  rowComponent: React.ComponentType<TableKeyboardNavigation.RowProps>;
  /** Applies a focused style to the row that contains the focused cell. */
  focusedRowEnabled?: boolean;
}
export interface KeyboardNavigationComponent extends TableKeyboardNavigation.CellProps {
}

/** Defines the column configuration object. Used to display data stored in a row. */
export interface Column {
    /*** Specifies the column name or the name of a row field whose value the column displays.
      * If the column name does not match any field name, specify the `getCellValue` function.
      **/
    name: string;
    /** Specifies the column title. */
    title?: string;
    /** Specifies the function used to get the column value for a given row. */
    getCellValue?: GetCellValueFn;
}
export declare type Row = any;
export declare type RowId = number | string;
export declare type GetCellValueFn = (row: any, columnName: string) => any;

export interface EditingColumnExtension {
    /** The name of a column to extend. */
    columnName: string;
    /** Specifies whether editing is enabled for a column. */
    editingEnabled?: boolean;
    /**
      * A function that returns a value specifying row changes depending on the columns' editor
      * values for the current row. This function is called each time the editor's value changes.
      */
    createRowChange?: (row: any, value: any, columnName: string) => any;
}
export interface EditingCell {
    rowId: number | string;
    columnName: string;
}

/** Describes a filter. */
export interface Filter {
    /** Specifies the name of a column whose value is used for filtering. */
    columnName: string;
    /** Specifies the operation name. The value is 'contains' if the operation name is not set. */
    operation?: FilterOperation;
    /** Specifies the filter value. */
    value?: any;
}
/** Describes data filtering expressions */
export interface FilterExpression {
    /** Specifies the Boolean operator */
    operator: 'and' | 'or';
    /** Specifies filters or filter expressions */
    filters: Array<FilterExpression | Filter>;
}
/*** Describes a filter operation. Accepts one of the built-in operations or a custom string.
  * Built-in operations: `contains`, `notContains`, `startsWith`, `endsWith`, `equal`, `notEqual`,
  * `greaterThan`, `greaterThanOrEqual`, `lessThan`, `lessThanOrEqual` */
export declare type FilterOperation = string;
export declare namespace IntegratedFiltering {
    /** Describes additional column properties that the plugin can handle. */
    interface ColumnExtension {
        /** The name of a column to extend. */
        columnName: string;
        /** A filter predicate. The `filter` parameter accepts an object containing the 'value' field. Note that you can use the onFilter event to extend this object to the fields your filtering algorithm requires. */
        predicate?: (value: any, filter: Filter, row: any) => boolean;
    }
}



/** Describes grouping options. */
export interface Grouping {
  /** Specifies the name of the column by which the data is grouped. */
  columnName: string;
}
/** Describes a group that can be nested in another one. */
export declare type GroupKey = string;
/** Describes the grouping panel item properties. */
export interface GroupingPanelItem {
  /** A column associated with the item. */
  column: Column;
  /** Specifies if the item is in preview mode */
  draft?: boolean;
}





export declare type SortingDirection = 'asc' | 'desc';
/** Describes the sorting applied to a column */
export interface Sorting {
  /** Specifies a column's name to which the sorting is applied. */
  columnName: string;
  /** Specifies a column's sorting order. */
  direction: SortingDirection;
}

/** Describes properties of a table row that the Table plugin renders. */
export interface TableRow {
    /** A unique table row identifier. */
    key: string;
    /*** Specifies the table row type. The specified value defines which cell template
      * is used to render the row. */
    type: symbol;
    /** Specifies the associated row's ID. */
    rowId?: number | string;
    /** Specifies the associated row. */
    row?: any;
    /** Specifies the table row height. */
    height?: number;
}
/** Describes properties of a table column that the Table plugin renders. */
export interface TableColumn {
    /** A unique table column identifier. */
    key: string;
    /*** Specifies the table column type. The specified value defines which cell template
      * is used to render the column. */
    type: symbol;
    /** Specifies the associated user column. */
    column?: Column;
    /** Specifies the table column width. */
    width?: number | string;
    /** Specifies the table's column alignment. */
    align?: 'left' | 'right' | 'center';
    /** Specifies the fixed table's column alignment. */
    fixed?: 'left' | 'right';
}
export declare type GridColumnExtension = {
    /** The name of the column to extend. */
    columnName: string;
    /** The table column width. */
    width?: number | string;
    /** The table column alignment. */
    align?: 'left' | 'right' | 'center';
    /** Specifies whether word wrap is enabled in a column's cells. */
    wordWrapEnabled?: boolean;
} & IntegratedFiltering.ColumnExtension;







/** Describes an object that specifies a column width. */
export interface TableColumnWidthInfo {
  /** A column name. */
  columnName: string;
  /** A column width. */
  width: number | string;
}
export interface ResizingSizes {
  /** A new column size. */
  size: number;
  /** A new next column size */
  nextSize?: number;
}
export interface ColumnSizes {
  /** A new column size. */
  width: number;
  /** A new next column size */
  size: number;
}
export declare namespace TableColumnResizing {
  /** Describes additional column properties that the plugin can handle. */
  interface ColumnExtension {
    /** A column name. */
    columnName: string;
    /** A column minimum width. */
    minWidth?: number;
    /** A column maximum width. */
    maxWidth?: number;
  }
}

/** Describes properties of column bands that the TableBandHeader plugin renders. */
export interface ColumnBands {
  /** A column name that is used to identify a column in the bands tree. */
  columnName?: string;
  /** The band's title. Used only for bands and ignored for columns. */
  title?: string;
  /** Nested bands and columns. */
  children?: ColumnBands[];
}



/** Describes the summary item associated with a column. */
export interface SummaryItem {
  /** The name of a column associated with the current summary item. */
  columnName: string;
  /** A summary type. */
  type: SummaryType;
}
export interface GroupSummaryItem extends SummaryItem {
  showInGroupFooter?: boolean;
  alignByColumn?: boolean;
}
export declare type SummaryType = string;
export declare type ColumnSummary = {
  type: SummaryType;
  value: SummaryValue;
};
export declare type SummaryValue = number | null;





export interface ColumnChooserItem {
  /** The grid column associated with the item. */
  column: Column;
  /** Specifies whether the associated column is hidden. */
  hidden: boolean;
}



export interface FocusedElement {
  rowKey: string;
  columnKey: string;
  index?: number;
  part: string;
}
export declare type FocusedElementWScrolling = {
  element?: FocusedElement;
  scrolling?: 'left' | 'right';
};
export declare type Elements = {
  [key: string]: any[];
};
export declare type ScrollToColumnFn = (value: symbol) => void;
export declare type InlineEditing = {
  stopEditCells?: (arg: any) => void;
  commitChangedRows?: (arg: any) => void;
  cancelChangedRows?: (arg: any) => void;
  startEditCells?: (arg: any) => void;
};
export declare type GetNextFocusedElementFn = PureComputed<[
  TableColumn[],
  TableRow[],
  TableRow[],
  RowId[],
  Elements,
  any,
  InlineEditing,
  FocusedElement?,
  ScrollToColumnFn?
], FocusedElementWScrolling>;
export declare type GetFocusedElementFn = PureComputed<[
  string,
  boolean,
  FocusedElement,
  TableColumn[],
  TableRow[],
  Elements
], FocusedElement | void>;
export declare type GetElementFn = PureComputed<[
  FocusedElement,
  TableRow[],
  TableColumn[],
  TableRow[],
  Elements,
  ScrollToColumnFn?
], FocusedElementWScrolling>;
export declare type GetElementPrevNextPartFn = PureComputed<[
  FocusedElement,
  Elements,
  TableRow[],
  TableColumn[],
  ScrollToColumnFn?
], FocusedElementWScrolling>;
export declare type GetInnerElementsFn = PureComputed<[
  Elements,
  string,
  string,
  string?
], any[]>;
export declare type GetNextPrevPartFn = PureComputed<[FocusedElement, Elements, TableRow[]], string | void>;
export declare type GetNextPrevCellFromBodyFn = PureComputed<[
  number,
  number,
  TableColumn[],
  TableRow[],
  FocusedElement,
  Elements,
  ScrollToColumnFn?
], FocusedElementWScrolling>;
export declare type GetPrevCellFromHeadingFn = PureComputed<[
  TableRow[],
  TableColumn[],
  number,
  FocusedElement,
  Elements
], FocusedElementWScrolling>;
export declare type GetNextCellFromHeadingFn = PureComputed<[
  TableRow[],
  TableRow[],
  TableColumn[],
  number,
  FocusedElement,
  Elements,
  ScrollToColumnFn?
], FocusedElementWScrolling>;
export declare type GetCellNextPrevPartFn = PureComputed<[
  FocusedElement,
  Elements,
  TableRow[],
  TableColumn[],
  number,
  ScrollToColumnFn?
], FocusedElementWScrolling>;
export interface FocusedCell {
  columnKey: string;
  rowKey: string;
}
export declare type OnFocusedCellChangeFn = (cell: FocusedCell) => void;

