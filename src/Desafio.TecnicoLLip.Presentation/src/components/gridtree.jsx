/* eslint-disable react/jsx-no-undef */
/* eslint-disable no-undef */
/* eslint-disable import/no-anonymous-default-export */
import React, { useState } from 'react';
import {
  DataTypeProvider,EditingState,RowDetailState,
  TreeDataState, SortingState, SelectionState, FilteringState, PagingState,
  CustomTreeData, IntegratedFiltering, IntegratedPaging, IntegratedSorting, IntegratedSelection,
} from '@devexpress/dx-react-grid';
import {
  Grid, TableRowDetail,TableEditColumn,
  Table, TableHeaderRow, TableFilterRow, TableTreeColumn,
  PagingPanel, TableColumnResizing, Toolbar, TableColumnVisibility, ColumnChooser
} from '@devexpress/dx-react-grid-bootstrap4';
import {
  Container, Row, Col, Label, FormGroup, Input, Button
} from 'reactstrap';



import {
  Plugin, Template, TemplateConnector, TemplatePlaceholder, Action,
} from '@devexpress/dx-react-core';
import classNames from 'clsx';

import { tasks, employees, priorities } from '../demo-data/tree-data';


const EmployeeFormatter = ({ row }) => (
  <div
    style={{
      display: 'flex',
    }}
  >
    <div
      style={{
        display: 'inline-block',
        background: 'white',
        borderRadius: '3px',
        width: '30px',
        height: '30px',
        margin: '-8px 8px -8px 0',
        textAlign: 'center',
      }}
    >
      <img
        src={`https://js.devexpress.com/Demos/WidgetsGallery/JSDemos/${employees.find(e => e.ID === row.Assigned_Employee_ID).Picture}`}
        style={{
          height: '28px',
          margin: '0 auto',
        }}
        alt="Avatar"
      />
    </div>
    {employees.find(e => e.ID === row.Assigned_Employee_ID).Name}
  </div>
);

const getChildRows = (row, rows) => {
  const childRows = rows.filter(r => r.Parent_ID === (row ? row.ID : 0));
  return childRows.length ? childRows : null;
};

function FieldGroup({ id, label, ...props }) {
  return (
    <FormGroup>
      <Label>{label}</Label>
      <Input {...props} />
    </FormGroup>
  );
}

const DetailContent = ({ row, ...rest }) => {
  const {
    processValueChange,
    applyChanges,
    cancelChanges,
  } = rest;
  return (
    <Container>
      <Row>
        <Col sm={4} className="px-2">
          <FieldGroup
            name="Subject"
            label="Subject"
            value={row.Prefix}
            onChange={processValueChange}
          />
        </Col>
        <Col sm={4} className="px-2">
          <FieldGroup
            name="Start_Date"
            label="Start Date"
            value={row.Start_Date}
            onChange={processValueChange}
          />
        </Col>
        <Col sm={4} className="px-2">
          <FieldGroup
            name="Due_Date"
            label="Due Date"
            value={row.Due_Date}
            onChange={processValueChange}
          />
          </Col>
          <Col sm={4} className="px-2">
            <FieldGroup
              name="Status"
              label="Status Date"
              value={row.Status}
              onChange={processValueChange}
            />
          </Col>
          <Col sm={4} className="px-2">
            <FieldGroup
              name="Completion"
              label="Completion"
              value={row.Completion}
              onChange={processValueChange}
            />
          </Col>
      </Row>
      <Row>
        <Col>
          <div className="float-right">
            <Button onClick={cancelChanges}>
              Cancel
            </Button>
            {' '}
            <Button onClick={applyChanges} color="primary">
              Save
            </Button>
          </div>
        </Col>
      </Row>
    </Container>
  );
};

const ToggleCell = ({
  expanded, onToggle,
  tableColumn, tableRow, row, style,
  ...restProps
}) => {
  const handleClick = (e) => {
    e.preventDefault();
    onToggle();
  };
  return (
    <td
      style={{
        cursor: 'pointer',
        verticalAlign: 'middle',
        textAlign: 'center',
        ...style,
      }}
      {...restProps}
    >
      <icon
        role="button"
        tabIndex={0}
        aria-label={expanded ? 'Close' : 'Edit'}
        className={classNames({
          oi: true,
          'oi-x': expanded,
          'oi-pencil': !expanded,
        })}
        onClick={handleClick}
        onKeyDown={handleClick}
        onKeyPress={handleClick}
      />
    </td>
  );
};

const DetailEditCell = () => (
  <Plugin name="detailEdit">
    <Action
      name="toggleDetailRowExpanded"
      action={({ rowId }, { expandedDetailRowIds }, { startEditRows, stopEditRows }) => {
        const rowIds = [rowId];
        const isCollapsing = expandedDetailRowIds.indexOf(rowId) > -1;
        if (isCollapsing) {
          stopEditRows({ rowIds });
        } else {
          startEditRows({ rowIds });
        }
      }}
    />
    <Template
      name="tableCell"
      predicate={({ tableRow }) => tableRow.type === TableRowDetail.ROW_TYPE}
    >
      {params => (
        <TemplateConnector>
          {({
            tableColumns,
            createRowChange,
            rowChanges,
          }, {
            changeRow,
            commitChangedRows,
            cancelChangedRows,
            toggleDetailRowExpanded,
          }) => {
            if (tableColumns.indexOf(params.tableColumn) !== 0) {
              return null;
            }
            const { tableRow: { rowId } } = params;
            const row = { ...params.tableRow.row, ...rowChanges[rowId] };

            const processValueChange = ({ target: { name, value } }) => {
              const changeArgs = {
                rowId,
                change: createRowChange(row, value, name),
              };
              changeRow(changeArgs);
            };

            const applyChanges = () => {
              toggleDetailRowExpanded({ rowId });
              commitChangedRows({ rowIds: [rowId] });
            };
            const cancelChanges = () => {
              toggleDetailRowExpanded({ rowId });
              cancelChangedRows({ rowIds: [rowId] });
            };

            return (
              <TemplatePlaceholder params={{
                ...params,
                row,
                tableRow: {
                  ...params.tableRow,
                  row,
                },
                changeRow,
                processValueChange,
                applyChanges,
                cancelChanges,
              }}
              />
            );
          }}
        </TemplateConnector>
      )}
    </Template>
  </Plugin>
);

const DetailCell = ({
  children, changeRow, editingRowIds, addedRows, processValueChange,
  applyChanges, cancelChanges,
  ...restProps
}) => {
  const { row } = restProps;

  return (
    <TableRowDetail.Cell {...restProps}>
      {React.cloneElement(children, {
        row, changeRow, processValueChange, applyChanges, cancelChanges,
      })}
    </TableRowDetail.Cell>
  );
};

export default () => {
  const [columns] = useState([
    { name: 'Subject', title: 'Task Subject' },
    { name: 'Assigned_Employee_ID', title: 'Assigned', getCellValue: row => employees.find(e => e.ID === row.Assigned_Employee_ID).Name },
    { name: 'Status', title: 'Status' },
    { name: 'Priority', title: 'Priority', getCellValue: row => priorities.find(p => p.ID === row.Priority).Value },
    { name: 'Completion', title: '% Completed', getCellValue: row => `${row.Completion}%` },
    { name: 'Start_Date', title: 'Start Date', getCellValue: row => row.Start_Date.split('T')[0] },
    { name: 'Due_Date', title: 'Due Date', getCellValue: row => row.Due_Date.split('T')[0] },
  ]);
  const [rows, setRows] = useState(tasks);
  const [pageSizes] = useState([5, 10, 20]);
  const [defaultColumnWidths] = useState([
    { columnName: 'Subject', width: 300 },
    { columnName: 'Assigned_Employee_ID', width: 180 },
    { columnName: 'Status', width: 120 },
    { columnName: 'Priority', width: 100 },
    { columnName: 'Completion', width: 100 },
    { columnName: 'Start_Date', width: 120 },
    { columnName: 'Due_Date', width: 120 },
  ]);
  const [defaultHiddenColumnNames] = useState(['Priority', 'Completion']);
  const [tableColumnExtensions] = useState([
    { columnName: 'Completion', align: 'right' },
  ]);
  const [employeeColumns] = useState(['Assigned_Employee_ID']);

  const commitChanges = ({ changed }) => {
    const changedRows = rows.map(row => (changed[row.ID] ? { ...row, ...changed[row.ID] } : row));
    setRows(changedRows);
  };  

  return (
    <div>

      <Grid
        rows={rows}
        columns={columns}
      >
        <DataTypeProvider
          for={employeeColumns}
          formatterComponent={EmployeeFormatter}
        />
        <RowDetailState />

        <EditingState
          onCommitChanges={commitChanges}
        />

        <TreeDataState />
        <FilteringState />
        <SortingState />
        <SelectionState />
        <PagingState
          defaultCurrentPage={0}
          defaultPageSize={pageSizes[1]}
        />

        <CustomTreeData
          getChildRows={getChildRows}
        />
        <IntegratedFiltering />
        <IntegratedSelection />
        <IntegratedSorting />
        <IntegratedPaging />
        <Table
          columnExtensions={tableColumnExtensions}
        />
        <TableColumnVisibility
          defaultHiddenColumnNames={defaultHiddenColumnNames}
        />
        <TableColumnResizing
          defaultColumnWidths={defaultColumnWidths}
        />
        <TableHeaderRow
          showSortingControls
        />
        <TableFilterRow />
        <TableTreeColumn
          for="Subject"
          showSelectionControls
          showSelectAll="true"
        />
        <TableRowDetail
          contentComponent={DetailContent}
          cellComponent={DetailCell}
          toggleCellComponent={ToggleCell}
        />
        <TableEditColumn
          showAddCommand
          showEditCommand
        />
        <Toolbar />
        <ColumnChooser />
        <DetailEditCell />
        <PagingPanel
          pageSizes={pageSizes}
        />
      </Grid>
    </div>
  );
};
